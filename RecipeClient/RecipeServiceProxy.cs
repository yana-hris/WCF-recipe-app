﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipeWcfService
{
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Recipe", Namespace="http://schemas.datacontract.org/2004/07/RecipeWcfService")]
    public partial class Recipe : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private System.Guid IdField;
        
        private string ImageUrlField;
        
        private string[] IngredientsField;
        
        private string InstructionsField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl
        {
            get
            {
                return this.ImageUrlField;
            }
            set
            {
                this.ImageUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Ingredients
        {
            get
            {
                return this.IngredientsField;
            }
            set
            {
                this.IngredientsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Instructions
        {
            get
            {
                return this.InstructionsField;
            }
            set
            {
                this.InstructionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IRecipeService")]
public interface IRecipeService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService/GetRecipes", ReplyAction="http://tempuri.org/IRecipeService/GetRecipesResponse")]
    RecipeWcfService.Recipe[] GetRecipes();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService/GetRecipes", ReplyAction="http://tempuri.org/IRecipeService/GetRecipesResponse")]
    System.Threading.Tasks.Task<RecipeWcfService.Recipe[]> GetRecipesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService/GetRecipeById", ReplyAction="http://tempuri.org/IRecipeService/GetRecipeByIdResponse")]
    RecipeWcfService.Recipe GetRecipeById(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecipeService/GetRecipeById", ReplyAction="http://tempuri.org/IRecipeService/GetRecipeByIdResponse")]
    System.Threading.Tasks.Task<RecipeWcfService.Recipe> GetRecipeByIdAsync(System.Guid id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IRecipeServiceChannel : IRecipeService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class RecipeServiceClient : System.ServiceModel.ClientBase<IRecipeService>, IRecipeService
{
    
    public RecipeServiceClient()
    {
    }
    
    public RecipeServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public RecipeServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RecipeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RecipeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public RecipeWcfService.Recipe[] GetRecipes()
    {
        return base.Channel.GetRecipes();
    }
    
    public System.Threading.Tasks.Task<RecipeWcfService.Recipe[]> GetRecipesAsync()
    {
        return base.Channel.GetRecipesAsync();
    }
    
    public RecipeWcfService.Recipe GetRecipeById(System.Guid id)
    {
        return base.Channel.GetRecipeById(id);
    }
    
    public System.Threading.Tasks.Task<RecipeWcfService.Recipe> GetRecipeByIdAsync(System.Guid id)
    {
        return base.Channel.GetRecipeByIdAsync(id);
    }
}
