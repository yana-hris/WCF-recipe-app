namespace RecipeWcfService
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    
    [DataContract]
    public class Recipe
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Instructions { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public List<string> Ingredients { get; set; }
    }
}
