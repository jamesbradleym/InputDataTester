// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace InputDataTester
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class InputDataTesterInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public InputDataTesterInputs(InputData @single, IList<InputData> @inputDataList, IList<Objects> @objects, Hierarchical @hierarchical, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<InputDataTesterInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @single, @inputDataList, @objects, @hierarchical});
            }
        
            this.Single = @single;
            this.InputDataList = @inputDataList;
            this.Objects = @objects;
            this.Hierarchical = @hierarchical;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Single", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InputData Single { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InputData List", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<InputData> InputDataList { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Objects", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<Objects> Objects { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Hierarchical", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Hierarchical Hierarchical { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Objects 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public Objects(InputData @file)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Objects>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @file});
            }
        
            this.File = @file;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("File", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InputData File { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Hierarchical 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public Hierarchical(IList<ANestedInputDataList> @aNestedInputDataList, InputData @nesTedINputDAta)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Hierarchical>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @aNestedInputDataList, @nesTedINputDAta});
            }
        
            this.ANestedInputDataList = @aNestedInputDataList;
            this.NesTedINputDAta = @nesTedINputDAta;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("A nested InputData List", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<ANestedInputDataList> ANestedInputDataList { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nesTed iNput DAta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InputData NesTedINputDAta { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class ANestedInputDataList 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public ANestedInputDataList(InputData @objectWithInputData)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<ANestedInputDataList>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @objectWithInputData});
            }
        
            this.ObjectWithInputData = @objectWithInputData;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Object with InputData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InputData ObjectWithInputData { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}