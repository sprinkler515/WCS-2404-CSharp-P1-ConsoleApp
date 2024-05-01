namespace P1_AppConsole.Features
{
    public class Feature
    {
        public DisplayFeature DisplayFeature { get; set; }
        public AddFeature AddFeature { get; set; }
        public RemoveFeature RemoveFeature { get; set; }
        public SearchFeature SearchFeature { get; set; }

        public Feature()
        {
            DisplayFeature = new();
            AddFeature = new();
            RemoveFeature = new();
            SearchFeature = new();
        }
    }
}
