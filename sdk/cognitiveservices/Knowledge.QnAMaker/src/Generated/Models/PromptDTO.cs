// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Prompt for an answer.
    /// </summary>
    public partial class PromptDTO
    {
        /// <summary>
        /// Initializes a new instance of the PromptDTO class.
        /// </summary>
        public PromptDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PromptDTO class.
        /// </summary>
        /// <param name="displayOrder">Index of the prompt - used in ordering
        /// of the prompts</param>
        /// <param name="qnaId">Qna id corresponding to the prompt - if QnaId
        /// is present, QnADTO object is ignored.</param>
        /// <param name="qna">QnADTO - Either QnaId or QnADTO needs to be
        /// present in a PromptDTO object</param>
        /// <param name="displayText">Text displayed to represent a follow up
        /// question prompt</param>
        public PromptDTO(int? displayOrder = default(int?), int? qnaId = default(int?), PromptDTOQna qna = default(PromptDTOQna), string displayText = default(string))
        {
            DisplayOrder = displayOrder;
            QnaId = qnaId;
            Qna = qna;
            DisplayText = displayText;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets index of the prompt - used in ordering of the prompts
        /// </summary>
        [JsonProperty(PropertyName = "displayOrder")]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets qna id corresponding to the prompt - if QnaId is
        /// present, QnADTO object is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "qnaId")]
        public int? QnaId { get; set; }

        /// <summary>
        /// Gets or sets qnADTO - Either QnaId or QnADTO needs to be present in
        /// a PromptDTO object
        /// </summary>
        [JsonProperty(PropertyName = "qna")]
        public PromptDTOQna Qna { get; set; }

        /// <summary>
        /// Gets or sets text displayed to represent a follow up question
        /// prompt
        /// </summary>
        [JsonProperty(PropertyName = "displayText")]
        public string DisplayText { get; set; }

    }
}
