using JetBrains.Annotations;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace AlexPovar.ResharperTweaks.ContextActions.ChopInline
{
  public class ChopMethodArgumentsAction : ChopInlineMethodActionBase
  {
    public ChopMethodArgumentsAction([NotNull] ICSharpParametersOwnerDeclaration methodDeclaration)
      : base(methodDeclaration)
    {
    }

    public override string Text => "Chop method arguments";
  }
}