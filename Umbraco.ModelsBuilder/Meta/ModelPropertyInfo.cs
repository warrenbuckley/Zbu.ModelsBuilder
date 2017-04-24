namespace Umbraco.ModelsBuilder.Meta
{
    public class ModelPropertyInfo
    {
        public ModelPropertyInfo(string alias, string clrName, string typeName)
        {
            Alias = alias;
            ClrName = clrName;
            TypeName = typeName;
        }

        public string Alias { get; }
        public string ClrName { get; }
        public string TypeName { get; }
    }
}