namespace RecipeWcfService
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRecipeService
    {
        [OperationContract]
        List<Recipe> GetRecipes();

        [OperationContract]
        Recipe GetRecipeById(Guid id);

        
    }
    
}
