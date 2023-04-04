public class AliasLinkWidget extends ParentWidget
{
    public static class VariableExpandingWidgetRoot {
    ...
}
// The problem with this was that VariableExpandingWidgetRoot had no need to be inside the scope of AliasLinkWidget.
// Moreover, other unrelated classes made use of AliasLinkWidget.VariableExpandingWidgetRoot.
// These classes had no need to know about AliasLinkWidget.

// Perhaps the programmer had plopped the VariableExpandingWidgetRoot into AliasWidget as a matter of convenience,
// or perhaps he thought it really needed to be scoped inside AliasWidget. Whatever the reason, the result wound up being arbitrary.
// Public classes that are not utilities of some other class should not be scoped inside another class.
// The convention is to make them public at the top level of their package.
