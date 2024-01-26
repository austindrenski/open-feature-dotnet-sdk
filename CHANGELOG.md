# Changelog

## [1.0.0](https://github.com/austindrenski/open-feature-dotnet-sdk/compare/v1.4.1...v1.0.0) (2024-01-26)


### ⚠ BREAKING CHANGES

* Add support for provider shutdown and status. ([#158](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/158))
* rename OpenFeature class to API and ns to OpenFeature ([#82](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/82))
* Thread safe hooks, provider, and context ([#79](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/79))
* Implement builders and immutable contexts. ([#77](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/77))
* ErrorType as enum, add ErrorMessage string ([#72](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/72))
* use correct path to extra file ([#63](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/63))
* Rename namespace from OpenFeature.SDK to OpenFeatureSDK ([#62](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/62))
* structure->value, object value constructor

### 🐛 Bug Fixes

* add dir to publish ([#69](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/69)) ([6549dbb](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6549dbb4f3a525a70cebdc9a63661ce6eaba9266))
* change NUGET_API_KEY -&gt; NUGET_TOKEN ([#67](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/67)) ([87c99b2](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/87c99b2128d50d72b54cb27e2f866f1edb0cd0d3))
* correct version range on logging ([#89](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/89)) ([9443239](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9443239adeb3144c6f683faf400dddf5ac493628))
* deadlocks in client applications ([#150](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/150)) ([17a7772](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/17a7772c0dad9c68a4a0e0e272fe32ce3bfe0cff))
* Fix ArgumentOutOfRangeException for empty hooks ([#187](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/187)) ([950775b](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/950775b65093e22ce209c947bf9da71b17ad7387))
* max System.Collections.Immutable version ++ ([#137](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/137)) ([55c5e8e](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/55c5e8e5c9e7667afb84d0b7946234e5274d4924))
* More robust shutdown/cleanup/reset ([#188](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/188)) ([a790f78](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/a790f78c32b8500ce27d04d906c98d1de2afd2b4))
* Remove upper-bound version constraint from SCI ([#171](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/171)) ([8f8b661](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/8f8b661f1cac6a4f1c51eb513999372d30a4f726))
* Rename namespace from OpenFeature.SDK to OpenFeatureSDK ([#62](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/62)) ([430ffc0](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/430ffc0a3afc871772286241d39a613c91298da5))
* substitute version number into filename when pushing package ([#65](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/65)) ([8c8500c](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/8c8500c71edb84c256b177c40815a34607adb682))
* use correct path to extra file ([#63](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/63)) ([ee39839](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/ee398399d9371517c4b03b55a93619776ecd3a92))


### ✨ New Features

* Add dx to catch ConfigureAwait(false) ([#152](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/152)) ([9c42d4a](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9c42d4afa9139094e0316bbe1306ae4856b7d013))
* add STATIC, CACHED reasons ([#101](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/101)) ([7cc7ab4](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/7cc7ab46fc20a97c9f4398f6d1fe80e43db514e1))
* add support for eventing ([#166](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/166)) ([f5fc1dd](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/f5fc1ddadc11f712ae0893cde815e7a1c6fe2c1b))
* Add support for provider hooks ([8cb5f6b](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/8cb5f6b9b683f004c34dea384453324947ee8460))
* Add support for provider shutdown and status. ([#158](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/158)) ([24c3441](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/24c344163423973b54a06b73648ba45b944589ee))
* ErrorType as enum, add ErrorMessage string ([#72](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/72)) ([e7ab498](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/e7ab49866bd83d7b146059b0c22944a7db6956b4))
* Implement builders and immutable contexts. ([#77](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/77)) ([d980a94](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/d980a94402bdb94cae4c60c1809f1579be7f5449))
* Implement seperate methods for integer and double ([778fa9b](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/778fa9b2d85a81e57b6f264e4405e4420023a577))
* include net7 in the test suit ([#97](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/97)) ([594d5f2](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/594d5f21f735473bf8585f9f6de67d758b1bf12c))
* Make IFeatureClient interface public. ([#102](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/102)) ([5a09c4f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/5a09c4f38c15b47b6e1aa62a57ea4f49c08fab77))
* rename OpenFeature class to API and ns to OpenFeature ([#82](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/82)) ([6090bd9](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6090bd971817cc6cc8b74487b2850d8e99a2c94d))
* split errors to classes by types ([#115](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/115)) ([5f348f4](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/5f348f46f2d9a5578a0db951bd78508ab74cabc0))
* structure-&gt;value, object value constructor ([f97d022](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/f97d0228c7d9f8946494dfeb3df82ded680a41c9))
* Support for name client to given provider ([#129](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/129)) ([3f765c6](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/3f765c6fb4ccd651de2d4f46e1fec38cd26610fe))
* Thread safe hooks, provider, and context ([#79](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/79)) ([609016f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/609016fc86f8eee8d848a9227b57aaef0d9b85b0))
* update ctx merge order, add client ctx ([9f3f879](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9f3f879b2fabf705ff2577d7ae5d0a737aa61827))
* Use dotnet-releaser to automate releases ([afe02d6](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/afe02d62e0b1b25693515b017fd7b2250ae85409))


### 🧹 Chore

* Add basic issue templates ([7ab12ea](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/7ab12ea21f307043fb9b5f1b3950a2056a5eae70))
* add CODEOWNERS ([6cd2b70](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6cd2b70264bb12e5e7bb88e9d26fe974632efb1b))
* add docs link ([#86](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/86)) ([69e4456](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/69e44568c4ec0200478dbc4ffc4de4e782b77e6e))
* add dotnet-format to the tools ([6388449](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6388449e86f0c15c165061d5aadc51aa5ec3179c))
* Add github action to perform release ([dad5a0c](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/dad5a0c5272d5687464c8067e27898c174ed3f8f))
* Add GitHub Actions logger for CI ([#174](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/174)) ([c1a189a](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/c1a189a5cff7106d37f0a45dd5824f18e7ec0cd6))
* Add openssf badge ([3104820](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/310482069fab88a46e71bab475f0e4c7012e2b7e))
* add placeholder eventing and shutdown sections ([#156](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/156)) ([5dfea29](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/5dfea29bb3d01f6c8640de321c4fde52f283a1c0))
* add spec badge ([#74](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/74)) ([71364f3](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/71364f3b0fcf7a981e1d8000d5764aad4e3a6e68))
* Add support for GitHub Packages ([#173](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/173)) ([26cd5cd](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/26cd5cdd613577c53ae79b889d1cf2d89262236f))
* Add test to cover spec 4.4.7 ([7ff1956](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/7ff19565fa32d95c3e34d6ba22d2ee1be0486204))
* Adding sealed keyword to classes ([#191](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/191)) ([1a14f6c](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/1a14f6cd6c8988756a2cf2da1137a739e8d960f8))
* Bump actions/setup-dotnet from 2 to 3 ([#75](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/75)) ([b59750b](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/b59750b6e72867781e53341da28b155ec77f8cbb))
* Bump amannn/action-semantic-pull-request from 4 to 5 ([#81](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/81)) ([d554057](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/d554057fa3b9e07caa3cc51d7be24f7fb34718d3))
* configure Renovate ([#88](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/88)) ([428e1ce](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/428e1ce0cf6aac735f2d7b21687c64759382e935))
* **deps:** Bump codecov/codecov-action from 3.1.0 to 3.1.1 ([77dd5f7](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/77dd5f75d767385481f768728f49f53f9fa7342a))
* **deps:** update actions/checkout action to v4 ([#144](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/144)) ([90d9d02](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/90d9d021b227fba626bb99454cb7c0f7fef2d8d8))
* **deps:** update actions/setup-dotnet action to v4 ([#162](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/162)) ([0b0bb10](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/0b0bb10419f836d9cc276fe8ac3c71c9214420ef))
* **deps:** update actions/upload-artifact action to v4.3.0 ([#203](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/203)) ([0a7e98d](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/0a7e98daf7d5f66f5aa8d97146e8444aa2685a33))
* **deps:** update codecov/codecov-action action to v3.1.2 ([#120](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/120)) ([b19e6e5](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/b19e6e540b43ed8d3fca4b19b85034cacc25da37))
* **deps:** update codecov/codecov-action action to v3.1.3 ([#123](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/123)) ([adfdf50](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/adfdf5038aa75c2ae4c0f909b21e0e69e165be28))
* **deps:** update codecov/codecov-action action to v3.1.4 ([#125](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/125)) ([6cab2d5](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6cab2d5c0ae09f0d0fef971a07777820f3ad075a))
* **deps:** update codecov/codecov-action action to v3.1.5 ([#209](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/209)) ([a509b1f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/a509b1fb1d360ea0ac25e515ef5c7827996d4b4e))
* **deps:** update dependency dotnet-sdk to v6.0.402 ([#91](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/91)) ([880344f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/880344f977bdc2658e42b94812f360c45498c4f1))
* **deps:** update dependency dotnet-sdk to v7.0.101 ([#99](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/99)) ([9e67a9f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9e67a9f9624ff4d344bba89168f82c5d7e7f001a))
* **deps:** update dependency dotnet-sdk to v7.0.102 ([#100](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/100)) ([9cf4154](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9cf4154a1cf29b0142d033e8d0d12c6cbe0b85c4))
* **deps:** update dependency dotnet-sdk to v7.0.202 ([#118](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/118)) ([5b8969e](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/5b8969ec2bcb1599ebcea4e9ce55d0e02d1d3ef8))
* **deps:** update dependency dotnet-sdk to v7.0.203 ([#121](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/121)) ([1d99726](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/1d99726abc6f9b4d6d36edffd6e9e67742990230))
* **deps:** update dependency dotnet-sdk to v7.0.302 ([#128](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/128)) ([3c5a633](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/3c5a63386066cbe79086db1d16ffaa8156473d50))
* **deps:** update dependency dotnet-sdk to v7.0.304 ([#134](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/134)) ([16f3300](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/16f3300094b4dececd9bcb00dfb3d2fffd255499))
* **deps:** update dependency dotnet-sdk to v7.0.306 ([#135](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/135)) ([15473b6](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/15473b6c3ab969ca660b7f3a98e1999373517b42))
* **deps:** update dependency dotnet-sdk to v7.0.400 ([#139](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/139)) ([ecc9707](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/ecc970701ff46815d0116417232f7c6ea670bdef))
* **deps:** update dependency dotnet-sdk to v7.0.404 ([#148](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/148)) ([e8ca1da](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/e8ca1da9ed63df9685ec49a9569e0ec99ba0b3b9))
* **deps:** update github/codeql-action action to v3 ([#163](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/163)) ([c85e93e](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/c85e93e9c9a97083660f9062c38dcbf6d64a3ad6))
* Enable Central Package Management (CPM) ([#178](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/178)) ([249a0a8](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/249a0a8b35d0205117153e8f32948d65b7754b44))
* Evaluation Context must only contain unique values ([2914554](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/291455429faa3ef714420ced0ffc1ec44da507de))
* exclude component in git tag ([#80](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/80)) ([6b70c30](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6b70c30013ea9a25472888bb1b45da18e1ba19a8))
* Exclude standard error from code coverage ([#130](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/130)) ([9152d63](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9152d631d4268bd3ce22f5075c287e26ee3d9b59))
* fix alt text for NuGet on the readme ([2cbdba8](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/2cbdba80d836f8b7850e8dc5f1f1790ef2ed1aca))
* Fix FieldCanBeMadeReadOnly ([#183](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/183)) ([18a092a](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/18a092afcab1b06c25f3b825a6130d22226790fc))
* Fix props to support more than one project ([#177](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/177)) ([f47cf07](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/f47cf07420cdcb6bc74b0455898b7b17a144daf3))
* fix release flow, add version.txt ([851900c](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/851900c22fe84f9dbb0de74d879ecb66387f25e0))
* Link to license file ([279737a](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/279737a98d4439ebc3ba2ce7c2ecd1e9b432ab05))
* **main:** release 0.2.0 ([#64](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/64)) ([45a3d95](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/45a3d95fae5a550e92fe1b9beddd20f1c505f289))
* **main:** release 0.2.1 ([#66](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/66)) ([63ecad0](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/63ecad04957a52b52e0be7fab32338b85dc3fc39))
* **main:** release 0.2.2 ([#68](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/68)) ([e15ead5](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/e15ead595597ea99d0e148edbc769fdf5bba0ea0))
* **main:** release 0.2.3 ([#70](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/70)) ([3ee7d08](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/3ee7d08b870da4a019858dfeca24200f8ea86366))
* **main:** release 0.3.0 ([#73](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/73)) ([a6e3d0c](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/a6e3d0cb3b18852e70f723ac227965a771c49f44))
* **main:** release 0.4.0 ([#78](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/78)) ([8b738da](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/8b738da959c887b7b718cf307853376b2e4f933f))
* **main:** release 0.5.0 ([#83](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/83)) ([80c2e1e](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/80c2e1eca2bf4493ba8af672ccbc02a45282ca19))
* **main:** release 1.0.0 ([#87](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/87)) ([a6363bd](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/a6363bd9b1af2d0329f81fd58ab1d4eabe33f7fb))
* **main:** release 1.0.1 ([#90](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/90)) ([4071b8e](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/4071b8e8b10dd635f92015aa18ae3742f6a77f93))
* **main:** release 1.1.0 ([#107](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/107)) ([6d820cb](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6d820cbaf4a240f6977f0dc7596b52c63d6fbd8c))
* **main:** release 1.2.0 ([#117](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/117)) ([83603f7](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/83603f70a97c6efdb9349d32240a2b56b3a7d50f))
* **main:** release 1.3.0 ([#133](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/133)) ([5ad83c4](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/5ad83c4e5f37b533a7a0ad88126c4ccfbaa9f604))
* **main:** release 1.3.1 ([#153](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/153)) ([dd92cbf](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/dd92cbf3ce379f32f66b3787e1cab6f14dd7de99))
* **main:** release 1.4.0 ([#154](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/154)) ([89d50bc](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/89d50bcb88069655fb69236bc390c499f8b0c1d4))
* **main:** release 1.4.1 ([#200](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/200)) ([c0fbbcd](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/c0fbbcdb8fc71bf69a25daf6245e40533a060a74))
* minor formatting cleanup ([#168](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/168)) ([d0c25af](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/d0c25af7df5176d10088c148eac35b0034536e04))
* Name the solution and project OpenFeature.SDK ([355bebc](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/355bebcaa77d85bfa05443c0f6c6b616b12ebbfd))
* Prove able to fetch all fields in EvaluationContext ([7eb400c](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/7eb400cf12a12f6cfdcff782cf662726763220d8))
* Reduce dependency on MEL -&gt; MELA ([#176](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/176)) ([a6062fe](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/a6062fe2b9f0d83490c7ce900e837863521f5f55))
* release 1.0.0 ([#85](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/85)) ([79c0d8d](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/79c0d8d0aa07f7aa69023de3437c3774df507e53))
* remove dependabot now we use renovate ([#93](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/93)) ([ba40c75](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/ba40c7513deb6c0e774bffe469806b78fd0bf42f))
* remove duplicate eventing section in readme ([1efe09d](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/1efe09da3948d5dfd7fd9f1c7a040fc5c2cbe833))
* Remove IHook inteface and just use Hook abstract class ([10329cf](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/10329cf061f92a6773e5ed61707007a808794e73))
* remove test sleeps, fix flaky test ([#194](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/194)) ([f2b9b03](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/f2b9b03eda5f6d6b4a738f761702cd9d9a105e76))
* revert breaking setProvider ([#190](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/190)) ([2919c2f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/2919c2f4f2a4629fccd1a50b1885375006445b96))
* SourceLink is built-in for .NET SDK 8.0.100+ ([#198](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/198)) ([45e2c86](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/45e2c862fd96092c3d20ddc5dfba46febfe802c8))
* Sync release.yml with ci.yml following [#173](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/173) ([#195](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/195)) ([eba8848](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/eba8848cb61f28b64f4a021f1534d300fcddf4eb))
* update link to ofep ([1f7e4cb](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/1f7e4cb622519a045351b053271c6cd64c395274))
* update readme ([3002333](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/300233323ebfdb4a64cf9efa3b63c4c7f93b7fb5))
* Update README basic usage. ([#96](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/96)) ([1612dc4](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/1612dc4ebd4128a845bf24ae79b90f8bc8c526d7))
* update rp config (emoji) ([f921dc6](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/f921dc699a358070568be93027680d49e0f7cb8e))
* update spec release link ([a2f70eb](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/a2f70ebd68357156f9045fc6e94845a53ffd204a))
* updated readme for inclusion in the docs ([6516866](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/6516866ec7601a7adaa4dc6b517c9287dec54fca))
* use release please ([b008b76](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/b008b76aa72fdd8f2d43b56808aea3842675db95))


### 📚 Documentation

* adapt README according to general template ([#122](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/122)) ([4a2e8ec](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/4a2e8ec118d1a64c030e697dd243645a7e649198))
* Add README.md to the nuget package ([#164](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/164)) ([b6b0ee2](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/b6b0ee2b61a9b0b973b913b53887badfa0c5a3de))
* add release please tag twice ([b34fe78](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/b34fe78636dfb6b2c334a68c44ae57b72b04acbc))
* add release please version range ([#201](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/201)) ([aa35e25](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/aa35e253b58755b4e0b75a4b272e5a368cb5566c))
* fix broken links ([#109](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/109)) ([bd730a5](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/bd730a52424214c1c917a80cf2cee03d0e4aafa8))
* fix release please tag ([8b1c9d2](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/8b1c9d2cc26c086dcdb2434ba8646ffc07c3d063))
* fixed the contrib url on the readme ([9d8939e](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/9d8939ef57a3be4ee220bd21f36b166887b2c30b))
* remove duplicate a tag from readme ([2687cf0](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/2687cf0663e20aa2dd113569cbf177833639cbbd))
* update readme to be pure markdown ([#199](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/199)) ([33db9d9](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/33db9d925478f8249e9fea7465998c8ec8da686b))
* Update README.md ([#147](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/147)) ([3da02e6](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/3da02e67a6e1e11af72fbd38aa42215b41b4e33b))
* update README.md ([#155](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/155)) ([b62e21f](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/b62e21f76964e7f6f7456f720814de0997232d71))
* update release please tags ([8dcb824](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/8dcb824e2b39e14e3b7345cd0d89f7660ca798cd))
* update the feature table key ([f8724cd](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/f8724cd625a1f9edb33cd208aac70db3766593f1))


### 🔄 Refactoring

* Add TFMs for net{6,7,8}.0 ([#172](https://github.com/austindrenski/open-feature-dotnet-sdk/issues/172)) ([cf2baa8](https://github.com/austindrenski/open-feature-dotnet-sdk/commit/cf2baa8a6b4328f1aa346bbea91160aa2e5f3a8d))

## [1.4.1](https://github.com/open-feature/dotnet-sdk/compare/v1.4.0...v1.4.1) (2024-01-23)


### 📚 Documentation

* add release please tag twice ([b34fe78](https://github.com/open-feature/dotnet-sdk/commit/b34fe78636dfb6b2c334a68c44ae57b72b04acbc))
* add release please version range ([#201](https://github.com/open-feature/dotnet-sdk/issues/201)) ([aa35e25](https://github.com/open-feature/dotnet-sdk/commit/aa35e253b58755b4e0b75a4b272e5a368cb5566c))
* fix release please tag ([8b1c9d2](https://github.com/open-feature/dotnet-sdk/commit/8b1c9d2cc26c086dcdb2434ba8646ffc07c3d063))
* update readme to be pure markdown ([#199](https://github.com/open-feature/dotnet-sdk/issues/199)) ([33db9d9](https://github.com/open-feature/dotnet-sdk/commit/33db9d925478f8249e9fea7465998c8ec8da686b))
* update release please tags ([8dcb824](https://github.com/open-feature/dotnet-sdk/commit/8dcb824e2b39e14e3b7345cd0d89f7660ca798cd))

## [1.4.0](https://github.com/open-feature/dotnet-sdk/compare/v1.3.1...v1.4.0) (2024-01-23)


### 🐛 Bug Fixes

* Fix ArgumentOutOfRangeException for empty hooks ([#187](https://github.com/open-feature/dotnet-sdk/issues/187)) ([950775b](https://github.com/open-feature/dotnet-sdk/commit/950775b65093e22ce209c947bf9da71b17ad7387))
* More robust shutdown/cleanup/reset ([#188](https://github.com/open-feature/dotnet-sdk/issues/188)) ([a790f78](https://github.com/open-feature/dotnet-sdk/commit/a790f78c32b8500ce27d04d906c98d1de2afd2b4))
* Remove upper-bound version constraint from SCI ([#171](https://github.com/open-feature/dotnet-sdk/issues/171)) ([8f8b661](https://github.com/open-feature/dotnet-sdk/commit/8f8b661f1cac6a4f1c51eb513999372d30a4f726))


### ✨ New Features

* Add dx to catch ConfigureAwait(false) ([#152](https://github.com/open-feature/dotnet-sdk/issues/152)) ([9c42d4a](https://github.com/open-feature/dotnet-sdk/commit/9c42d4afa9139094e0316bbe1306ae4856b7d013))
* add support for eventing ([#166](https://github.com/open-feature/dotnet-sdk/issues/166)) ([f5fc1dd](https://github.com/open-feature/dotnet-sdk/commit/f5fc1ddadc11f712ae0893cde815e7a1c6fe2c1b))
* Add support for provider shutdown and status. ([#158](https://github.com/open-feature/dotnet-sdk/issues/158)) ([24c3441](https://github.com/open-feature/dotnet-sdk/commit/24c344163423973b54a06b73648ba45b944589ee))


### 🧹 Chore

* Add GitHub Actions logger for CI ([#174](https://github.com/open-feature/dotnet-sdk/issues/174)) ([c1a189a](https://github.com/open-feature/dotnet-sdk/commit/c1a189a5cff7106d37f0a45dd5824f18e7ec0cd6))
* add placeholder eventing and shutdown sections ([#156](https://github.com/open-feature/dotnet-sdk/issues/156)) ([5dfea29](https://github.com/open-feature/dotnet-sdk/commit/5dfea29bb3d01f6c8640de321c4fde52f283a1c0))
* Add support for GitHub Packages ([#173](https://github.com/open-feature/dotnet-sdk/issues/173)) ([26cd5cd](https://github.com/open-feature/dotnet-sdk/commit/26cd5cdd613577c53ae79b889d1cf2d89262236f))
* Adding sealed keyword to classes ([#191](https://github.com/open-feature/dotnet-sdk/issues/191)) ([1a14f6c](https://github.com/open-feature/dotnet-sdk/commit/1a14f6cd6c8988756a2cf2da1137a739e8d960f8))
* **deps:** update actions/checkout action to v4 ([#144](https://github.com/open-feature/dotnet-sdk/issues/144)) ([90d9d02](https://github.com/open-feature/dotnet-sdk/commit/90d9d021b227fba626bb99454cb7c0f7fef2d8d8))
* **deps:** update actions/setup-dotnet action to v4 ([#162](https://github.com/open-feature/dotnet-sdk/issues/162)) ([0b0bb10](https://github.com/open-feature/dotnet-sdk/commit/0b0bb10419f836d9cc276fe8ac3c71c9214420ef))
* **deps:** update dependency dotnet-sdk to v7.0.404 ([#148](https://github.com/open-feature/dotnet-sdk/issues/148)) ([e8ca1da](https://github.com/open-feature/dotnet-sdk/commit/e8ca1da9ed63df9685ec49a9569e0ec99ba0b3b9))
* **deps:** update github/codeql-action action to v3 ([#163](https://github.com/open-feature/dotnet-sdk/issues/163)) ([c85e93e](https://github.com/open-feature/dotnet-sdk/commit/c85e93e9c9a97083660f9062c38dcbf6d64a3ad6))
* fix alt text for NuGet on the readme ([2cbdba8](https://github.com/open-feature/dotnet-sdk/commit/2cbdba80d836f8b7850e8dc5f1f1790ef2ed1aca))
* Fix FieldCanBeMadeReadOnly ([#183](https://github.com/open-feature/dotnet-sdk/issues/183)) ([18a092a](https://github.com/open-feature/dotnet-sdk/commit/18a092afcab1b06c25f3b825a6130d22226790fc))
* Fix props to support more than one project ([#177](https://github.com/open-feature/dotnet-sdk/issues/177)) ([f47cf07](https://github.com/open-feature/dotnet-sdk/commit/f47cf07420cdcb6bc74b0455898b7b17a144daf3))
* minor formatting cleanup ([#168](https://github.com/open-feature/dotnet-sdk/issues/168)) ([d0c25af](https://github.com/open-feature/dotnet-sdk/commit/d0c25af7df5176d10088c148eac35b0034536e04))
* Reduce dependency on MEL -&gt; MELA ([#176](https://github.com/open-feature/dotnet-sdk/issues/176)) ([a6062fe](https://github.com/open-feature/dotnet-sdk/commit/a6062fe2b9f0d83490c7ce900e837863521f5f55))
* remove duplicate eventing section in readme ([1efe09d](https://github.com/open-feature/dotnet-sdk/commit/1efe09da3948d5dfd7fd9f1c7a040fc5c2cbe833))
* remove test sleeps, fix flaky test ([#194](https://github.com/open-feature/dotnet-sdk/issues/194)) ([f2b9b03](https://github.com/open-feature/dotnet-sdk/commit/f2b9b03eda5f6d6b4a738f761702cd9d9a105e76))
* revert breaking setProvider ([#190](https://github.com/open-feature/dotnet-sdk/issues/190)) ([2919c2f](https://github.com/open-feature/dotnet-sdk/commit/2919c2f4f2a4629fccd1a50b1885375006445b96))
* update spec release link ([a2f70eb](https://github.com/open-feature/dotnet-sdk/commit/a2f70ebd68357156f9045fc6e94845a53ffd204a))
* updated readme for inclusion in the docs ([6516866](https://github.com/open-feature/dotnet-sdk/commit/6516866ec7601a7adaa4dc6b517c9287dec54fca))


### 📚 Documentation

* Add README.md to the nuget package ([#164](https://github.com/open-feature/dotnet-sdk/issues/164)) ([b6b0ee2](https://github.com/open-feature/dotnet-sdk/commit/b6b0ee2b61a9b0b973b913b53887badfa0c5a3de))
* fixed the contrib url on the readme ([9d8939e](https://github.com/open-feature/dotnet-sdk/commit/9d8939ef57a3be4ee220bd21f36b166887b2c30b))
* remove duplicate a tag from readme ([2687cf0](https://github.com/open-feature/dotnet-sdk/commit/2687cf0663e20aa2dd113569cbf177833639cbbd))
* update README.md ([#155](https://github.com/open-feature/dotnet-sdk/issues/155)) ([b62e21f](https://github.com/open-feature/dotnet-sdk/commit/b62e21f76964e7f6f7456f720814de0997232d71))


### 🔄 Refactoring

* Add TFMs for net{6,7,8}.0 ([#172](https://github.com/open-feature/dotnet-sdk/issues/172)) ([cf2baa8](https://github.com/open-feature/dotnet-sdk/commit/cf2baa8a6b4328f1aa346bbea91160aa2e5f3a8d))

## [1.3.1](https://github.com/open-feature/dotnet-sdk/compare/v1.3.0...v1.3.1) (2023-09-19)


### 🐛 Bug Fixes

* deadlocks in client applications ([#150](https://github.com/open-feature/dotnet-sdk/issues/150)) ([17a7772](https://github.com/open-feature/dotnet-sdk/commit/17a7772c0dad9c68a4a0e0e272fe32ce3bfe0cff))


### 🧹 Chore

* **deps:** update dependency dotnet-sdk to v7.0.306 ([#135](https://github.com/open-feature/dotnet-sdk/issues/135)) ([15473b6](https://github.com/open-feature/dotnet-sdk/commit/15473b6c3ab969ca660b7f3a98e1999373517b42))
* **deps:** update dependency dotnet-sdk to v7.0.400 ([#139](https://github.com/open-feature/dotnet-sdk/issues/139)) ([ecc9707](https://github.com/open-feature/dotnet-sdk/commit/ecc970701ff46815d0116417232f7c6ea670bdef))
* update rp config (emoji) ([f921dc6](https://github.com/open-feature/dotnet-sdk/commit/f921dc699a358070568be93027680d49e0f7cb8e))


### 📚 Documentation

* Update README.md ([#147](https://github.com/open-feature/dotnet-sdk/issues/147)) ([3da02e6](https://github.com/open-feature/dotnet-sdk/commit/3da02e67a6e1e11af72fbd38aa42215b41b4e33b))

## [1.3.0](https://github.com/open-feature/dotnet-sdk/compare/v1.2.0...v1.3.0) (2023-07-14)


### Features

* Support for name client to given provider ([#129](https://github.com/open-feature/dotnet-sdk/issues/129)) ([3f765c6](https://github.com/open-feature/dotnet-sdk/commit/3f765c6fb4ccd651de2d4f46e1fec38cd26610fe))


### Bug Fixes

* max System.Collections.Immutable version ++ ([#137](https://github.com/open-feature/dotnet-sdk/issues/137)) ([55c5e8e](https://github.com/open-feature/dotnet-sdk/commit/55c5e8e5c9e7667afb84d0b7946234e5274d4924))

## [1.2.0](https://github.com/open-feature/dotnet-sdk/compare/v1.1.0...v1.2.0) (2023-02-14)


### Features

* split errors to classes by types ([#115](https://github.com/open-feature/dotnet-sdk/issues/115)) ([5f348f4](https://github.com/open-feature/dotnet-sdk/commit/5f348f46f2d9a5578a0db951bd78508ab74cabc0))

## [1.1.0](https://github.com/open-feature/dotnet-sdk/compare/v1.0.1...v1.1.0) (2023-01-18)


### Features

* add STATIC, CACHED reasons ([#101](https://github.com/open-feature/dotnet-sdk/issues/101)) ([7cc7ab4](https://github.com/open-feature/dotnet-sdk/commit/7cc7ab46fc20a97c9f4398f6d1fe80e43db514e1))
* include net7 in the test suit ([#97](https://github.com/open-feature/dotnet-sdk/issues/97)) ([594d5f2](https://github.com/open-feature/dotnet-sdk/commit/594d5f21f735473bf8585f9f6de67d758b1bf12c))
* Make IFeatureClient interface public. ([#102](https://github.com/open-feature/dotnet-sdk/issues/102)) ([5a09c4f](https://github.com/open-feature/dotnet-sdk/commit/5a09c4f38c15b47b6e1aa62a57ea4f49c08fab77))

## [1.0.1](https://github.com/open-feature/dotnet-sdk/compare/v1.0.0...v1.0.1) (2022-10-28)


### Bug Fixes

* correct version range on logging ([#89](https://github.com/open-feature/dotnet-sdk/issues/89)) ([9443239](https://github.com/open-feature/dotnet-sdk/commit/9443239adeb3144c6f683faf400dddf5ac493628))

## [1.0.0](https://github.com/open-feature/dotnet-sdk/compare/v0.5.0...v1.0.0) (2022-10-21)


### Miscellaneous Chores

* release 1.0.0 ([#85](https://github.com/open-feature/dotnet-sdk/issues/85)) ([79c0d8d](https://github.com/open-feature/dotnet-sdk/commit/79c0d8d0aa07f7aa69023de3437c3774df507e53))

## [0.5.0](https://github.com/open-feature/dotnet-sdk/compare/v0.4.0...v0.5.0) (2022-10-16)


### ⚠ BREAKING CHANGES

* rename OpenFeature class to API and ns to OpenFeature (#82)

### Features

* rename OpenFeature class to API and ns to OpenFeature ([#82](https://github.com/open-feature/dotnet-sdk/issues/82)) ([6090bd9](https://github.com/open-feature/dotnet-sdk/commit/6090bd971817cc6cc8b74487b2850d8e99a2c94d))

## [0.4.0](https://github.com/open-feature/dotnet-sdk/compare/v0.3.0...v0.4.0) (2022-10-12)


### ⚠ BREAKING CHANGES

* Thread safe hooks, provider, and context (#79)
* Implement builders and immutable contexts. (#77)

### Features

* Implement builders and immutable contexts. ([#77](https://github.com/open-feature/dotnet-sdk/issues/77)) ([d980a94](https://github.com/open-feature/dotnet-sdk/commit/d980a94402bdb94cae4c60c1809f1579be7f5449))
* Thread safe hooks, provider, and context ([#79](https://github.com/open-feature/dotnet-sdk/issues/79)) ([609016f](https://github.com/open-feature/dotnet-sdk/commit/609016fc86f8eee8d848a9227b57aaef0d9b85b0))

## [0.3.0](https://github.com/open-feature/dotnet-sdk/compare/v0.2.3...v0.3.0) (2022-09-28)


### ⚠ BREAKING CHANGES

* ErrorType as enum, add ErrorMessage string (#72)

### Features

* ErrorType as enum, add ErrorMessage string ([#72](https://github.com/open-feature/dotnet-sdk/issues/72)) ([e7ab498](https://github.com/open-feature/dotnet-sdk/commit/e7ab49866bd83d7b146059b0c22944a7db6956b4))

## [0.2.3](https://github.com/open-feature/dotnet-sdk/compare/v0.2.2...v0.2.3) (2022-09-22)


### Bug Fixes

* add dir to publish ([#69](https://github.com/open-feature/dotnet-sdk/issues/69)) ([6549dbb](https://github.com/open-feature/dotnet-sdk/commit/6549dbb4f3a525a70cebdc9a63661ce6eaba9266))

## [0.2.2](https://github.com/open-feature/dotnet-sdk/compare/v0.2.1...v0.2.2) (2022-09-22)


### Bug Fixes

* change NUGET_API_KEY -> NUGET_TOKEN ([#67](https://github.com/open-feature/dotnet-sdk/issues/67)) ([87c99b2](https://github.com/open-feature/dotnet-sdk/commit/87c99b2128d50d72b54cb27e2f866f1edb0cd0d3))

## [0.2.1](https://github.com/open-feature/dotnet-sdk/compare/v0.2.0...v0.2.1) (2022-09-22)


### Bug Fixes

* substitute version number into filename when pushing package ([#65](https://github.com/open-feature/dotnet-sdk/issues/65)) ([8c8500c](https://github.com/open-feature/dotnet-sdk/commit/8c8500c71edb84c256b177c40815a34607adb682))

## [0.2.0](https://github.com/open-feature/dotnet-sdk/compare/v0.1.5...v0.2.0) (2022-09-22)


### ⚠ BREAKING CHANGES

* use correct path to extra file (#63)
* Rename namespace from OpenFeature.SDK to OpenFeatureSDK (#62)

### Bug Fixes

* Rename namespace from OpenFeature.SDK to OpenFeatureSDK ([#62](https://github.com/open-feature/dotnet-sdk/issues/62)) ([430ffc0](https://github.com/open-feature/dotnet-sdk/commit/430ffc0a3afc871772286241d39a613c91298da5))
* use correct path to extra file ([#63](https://github.com/open-feature/dotnet-sdk/issues/63)) ([ee39839](https://github.com/open-feature/dotnet-sdk/commit/ee398399d9371517c4b03b55a93619776ecd3a92))
