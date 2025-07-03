using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System;

namespace WebExtension.HTML.InputModel
{
    [
        AttributeUsage(
            AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Parameter,
            AllowMultiple = false
        )
    ]
    public class InputModelAttribute : Attribute, IDisplayMetadataProvider
    {
        #region Variables
        private InputModeEnum V_InputMode;
        #endregion

        #region Enum
        public enum InputModeEnum
        {
            none,
            text,
            @decimal,
            numeric,
            tel,
            search,
            email,
            url
        }
        #endregion



        #region Constructor Method
        public InputModelAttribute(InputModeEnum InputMode)
        {
            this.V_InputMode = InputMode;
        }
        #endregion



        #region Property
        public InputModeEnum InputMode
        {
            get => this.V_InputMode;
        }
        #endregion



        public void CreateDisplayMetadata(DisplayMetadataProviderContext context)
        {
            // Agrega metadata personalizada accesible por Razor
            context.DisplayMetadata.AdditionalValues["InputMode"] = InputMode.ToString();
        }
    }
}