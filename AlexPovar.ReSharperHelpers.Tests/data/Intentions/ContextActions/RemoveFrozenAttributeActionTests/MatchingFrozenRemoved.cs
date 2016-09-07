﻿namespace AlexPovar.ReSharperHelpers.Tests.data.Intentions.ContextActions.RemoveFrozenAttributeActionTests
{
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using Ploeh.AutoFixture.Xunit2;

  public class MatchingFrozenRemoved
  {
    public void TestMethod([Frozen(Matching.ExactType)] string some{caret}Arg) { }
  }
}

namespace Ploeh.AutoFixture.Xunit2
{
  using System;

  public class FrozenAttribute: Attribute
  {
    public FrozenAttribute(Matching by) { }
  }

  public enum Matching
  {
    ExactType
  }
}
