using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace InputDataTester
{
    public static class InputDataTester
    {
        /// <summary>
        /// The InputDataTester function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A InputDataTesterOutputs instance containing computed results and the model with any new elements.</returns>
        public static InputDataTesterOutputs Execute(Dictionary<string, Model> inputModels, InputDataTesterInputs input)
        {
            var warnings = new List<string>();

            warnings.Add($"Single: {input.Single.LocalFilePath}");

            foreach (var inputFile in input.InputDataList)
            {
                warnings.Add($"InputDataList: {inputFile.LocalFilePath}");
            }
            foreach (var inputFile in input.Objects)
            {
                warnings.Add($"Objects: {inputFile.File.LocalFilePath}");

            }
            foreach (var inputFile in input.Hierarchical.ANestedInputDataList)
            {
                warnings.Add($"Hierarchical: {inputFile.ObjectWithInputData.LocalFilePath}");
            }
            warnings.Add($"Hierarchical->NestedInputData: {input.Hierarchical.NesTedINputDAta.LocalFilePath}");
            var output = new InputDataTesterOutputs();
            output.Warnings.AddRange(warnings);
            return output;
        }
    }
}