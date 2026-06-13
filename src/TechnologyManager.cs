namespace Subnautica2BlueprintTracker
{
    public class TechnologyManager
    {
        public int UnlockedTechnologies { get; set; }

        public int TotalTechnologies { get; set; }

        public double GetProgress()
        {
            if (TotalTechnologies == 0)
                return 0;

            return (double)UnlockedTechnologies / TotalTechnologies * 100;
        }
    }
}
