namespace Umbraco.ModelsBuilder.Meta
{
    public class ModelTypeInfo
    {
        public ModelTypeInfo(string alias, string clrName, ModelPropertyInfo[] properties)
        {
            Alias = alias;
            ClrName = clrName;
            Properties = properties;
        }

        public string Alias { get; }
        public string ClrName { get; }
        public ModelPropertyInfo[] Properties { get; }
    }
}