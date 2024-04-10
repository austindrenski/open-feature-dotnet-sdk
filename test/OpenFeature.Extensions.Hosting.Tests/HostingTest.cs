using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using OpenFeature.Model;
using Xunit;

namespace OpenFeature.Tests;

public sealed class HostingTest
{
    [Fact]
    public async Task Can_register_no_op()
    {
        var builder = Host.CreateApplicationBuilder();

        builder.Services.AddOpenFeature();

        using var app = builder.Build();

        await app.StartAsync().ConfigureAwait(false);

        Assert.Equal(Api.Instance, app.Services.GetRequiredService<Api>());
        Assert.Equal(Api.Instance.GetProviderMetadata().Name, app.Services.GetRequiredService<IFeatureClient>().GetMetadata().Name);

        Assert.Empty(Api.Instance.GetContext().AsDictionary());
        Assert.Empty(app.Services.GetRequiredService<EvaluationContextBuilder>().Build().AsDictionary());
        Assert.Empty(app.Services.GetServices<EvaluationContext>());
        Assert.Empty(app.Services.GetServices<Hook>());
        Assert.Empty(app.Services.GetServices<FeatureProvider>());

        await app.StopAsync().ConfigureAwait(false);
    }

    [Fact]
    public async Task Can_register_some_feature_provider()
    {
        var builder = Host.CreateApplicationBuilder();

        builder.Services.AddOpenFeature(static builder =>
        {
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<FeatureProvider, SomeFeatureProvider>());
            builder.TryAddOpenFeatureClient(SomeFeatureProvider.Name);
        });

        using var app = builder.Build();

        Assert.Equal(Api.Instance, app.Services.GetRequiredService<Api>());
        Assert.Equal("No-op Provider", app.Services.GetRequiredService<Api>().GetProviderMetadata().Name);

        await app.StartAsync().ConfigureAwait(false);

        Assert.Equal(Api.Instance, app.Services.GetRequiredService<Api>());
        Assert.Equal(SomeFeatureProvider.Name, app.Services.GetRequiredService<Api>().GetProviderMetadata().Name);
        Assert.Equal(SomeFeatureProvider.Name, app.Services.GetRequiredService<IFeatureClient>().GetMetadata().Name);

        Assert.Empty(Api.Instance.GetContext().AsDictionary());
        Assert.Empty(app.Services.GetRequiredService<EvaluationContextBuilder>().Build().AsDictionary());
        Assert.Empty(app.Services.GetServices<EvaluationContext>());
        Assert.Empty(app.Services.GetServices<Hook>());
        Assert.NotEmpty(app.Services.GetServices<FeatureProvider>());

        await app.StopAsync().ConfigureAwait(false);
    }

    sealed class SomeFeatureProvider : FeatureProvider
    {
        public const string Name = "some_feature_provider";

        public override Metadata GetMetadata() => new(Name);

        public override Task<ResolutionDetails<bool>> ResolveBooleanValue(string flagKey, bool defaultValue, EvaluationContext? context = null)
            => Task.FromResult(new ResolutionDetails<bool>(flagKey, defaultValue));

        public override Task<ResolutionDetails<string>> ResolveStringValue(string flagKey, string defaultValue, EvaluationContext? context = null)
            => Task.FromResult(new ResolutionDetails<string>(flagKey, defaultValue));

        public override Task<ResolutionDetails<int>> ResolveIntegerValue(string flagKey, int defaultValue, EvaluationContext? context = null)
            => Task.FromResult(new ResolutionDetails<int>(flagKey, defaultValue));

        public override Task<ResolutionDetails<double>> ResolveDoubleValue(string flagKey, double defaultValue, EvaluationContext? context = null)
            => Task.FromResult(new ResolutionDetails<double>(flagKey, defaultValue));

        public override Task<ResolutionDetails<Value>> ResolveStructureValue(string flagKey, Value defaultValue, EvaluationContext? context = null)
            => Task.FromResult(new ResolutionDetails<Value>(flagKey, defaultValue));
    }
}