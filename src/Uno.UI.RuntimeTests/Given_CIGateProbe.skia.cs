#nullable enable

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.UI.RuntimeTests.Helpers;

namespace Uno.UI.RuntimeTests.Tests;

// Throwaway probe for #25648: proves the Apple run-step gate turns a shard red. Remove before merge.
[TestClass]
[PlatformCondition(ConditionMode.Include, RuntimeTestPlatforms.SkiaUIKit)]
public class Given_CIGateProbe
{
	[TestMethod]
	public void When_Probe_Runs_Then_The_Shard_Fails()
	{
		Assert.Fail("Throwaway probe: the run-step gate must turn this shard red.");
	}
}
