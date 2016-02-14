﻿namespace RushHour.Experiments
{
    public static class ExperimentsToggle
    {
        /// <summary>
        /// Set this to true to enable the experimental deathcare, which takes into
        /// consideration more realistic behaviour. Hearses pick up from hospitals,
        /// and dead people are transported to hospitals by ambulances. Non functional.
        /// </summary>
        public static bool ImprovedDeathcare = false;     
        
        /// <summary>
        /// Prints all monuments in your city to the console.
        /// </summary>
        public static bool PrintAllMonuments = false;

        /// <summary>
        /// Forces an event to happen as soon as the last one is removed from the
        /// event list. Will queue up another a bit after the last one has ended.
        /// </summary>
        public static bool ForceEventToHappen = false;

        /// <summary>
        /// Improved commercial demand for Rush Hour. Better than the normal behaviour
        /// hopefully.
        /// </summary>
        public static bool ImprovedCommercialDemand = false;

        /// <summary>
        /// Enable random events to be initialised by the city.
        /// </summary>
        public static bool EnableRandomEvents = true;

        /// <summary>
        /// Enables weekends, where Cims don't go to work.
        /// </summary>
        public static bool EnableWeekends = true;

        /// <summary>
        /// Redirects reverted code. Potentially crashes, so this is here for experimentation
        /// </summary>
        public static bool RevertRedirects = false;

        /// <summary>
        /// Slows time down 4x so rush hour can happen properly
        /// </summary>
        public static bool SlowTimeProgression = false;

        /// <summary>
        /// Uses the new XML events
        /// </summary>
        public static bool UseXMLEvents = true;

        /// <summary>
        /// The retry time for tourists to find a hotel.
        /// </summary>
        public static int TouristHotelRetryAmount = 8;

        /// <summary>
        /// The retry time for citizens to find leisure specialised areas at night.
        /// </summary>
        public static int CitizenLeisureRetryAmount = 8;
    }
}
