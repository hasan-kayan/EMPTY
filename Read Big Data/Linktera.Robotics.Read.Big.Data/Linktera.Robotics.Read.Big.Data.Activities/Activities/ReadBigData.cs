using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using Linktera.Robotics.Read.Big.Data.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Linktera.Robotics.Read.Big.Data.Activities
{
    [LocalizedDisplayName(nameof(Resources.ReadBigData_DisplayName))]
    [LocalizedDescription(nameof(Resources.ReadBigData_Description))]
    public class ReadBigData : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.ReadBigData_Path_DisplayName))]
        [LocalizedDescription(nameof(Resources.ReadBigData_Path_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Path { get; set; }

        [LocalizedDisplayName(nameof(Resources.ReadBigData_Sheet_DisplayName))]
        [LocalizedDescription(nameof(Resources.ReadBigData_Sheet_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Sheet { get; set; }

        [LocalizedDisplayName(nameof(Resources.ReadBigData_Range_DisplayName))]
        [LocalizedDescription(nameof(Resources.ReadBigData_Range_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Range { get; set; }

        [LocalizedDisplayName(nameof(Resources.ReadBigData_Outdata_DisplayName))]
        [LocalizedDescription(nameof(Resources.ReadBigData_Outdata_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<DataTable> Outdata { get; set; }

        #endregion


        #region Constructors

        public ReadBigData()
        {
        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (Path == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(Path)));
            if (Sheet == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(Sheet)));
            if (Range == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(Range)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            var path = Path.Get(context);
            var sheet = Sheet.Get(context);
            var range = Range.Get(context);
    
            ///////////////////////////
            // Add execution logic HERE
            ///////////////////////////

            // Outputs
            return (ctx) => {
                Outdata.Set(ctx, null);
            };
        }

        #endregion
    }
}

