﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.PowerShell.Cmdlets.Blueprint.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.PowerShell.Cmdlets.Blueprint.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An artifact with name &apos;{0}&apos; in blueprint &apos;{1}&apos; already exists. Please use Set-AzBlueprintArtifact to update an existing artifact..
        /// </summary>
        internal static string ArtifactExists {
            get {
                return ResourceManager.GetString("ArtifactExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An artifact with name &apos;{0}&apos; in blueprint &apos;{1}&apos; does not exist. Please use New- AzBlueprintArtifact to create a new artifact..
        /// </summary>
        internal static string ArtifactNotExist {
            get {
                return ResourceManager.GetString("ArtifactNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Artifact type is not supported..
        /// </summary>
        internal static string ArtifactTypeNotSupported {
            get {
                return ResourceManager.GetString("ArtifactTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An assignment with name &apos;{0}&apos; in subscription &apos;{1}&apos; already exists. Please use Set-AzBlueprintAssignment to update an existing assignment..
        /// </summary>
        internal static string AssignmentExists {
            get {
                return ResourceManager.GetString("AssignmentExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An assignment with name &apos;{0}&apos; in subscription &apos;{1}&apos; does not exist. Please use New-AzBlueprintAssignment to create a new assignment..
        /// </summary>
        internal static string AssignmentNotExist {
            get {
                return ResourceManager.GetString("AssignmentNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A blueprint with name &apos;{0}&apos; in subscription &apos;{1}&apos; already exists. Please use Set-AzBlueprint to update an existing blueprint..
        /// </summary>
        internal static string BlueprintExists {
            get {
                return ResourceManager.GetString("BlueprintExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A blueprint with name &apos;{0}&apos; in subscription &apos;{1}&apos; does not exist. Please use New-AzBlueprint to create a new blueprint..
        /// </summary>
        internal static string BlueprintNotExist {
            get {
                return ResourceManager.GetString("BlueprintNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find Blueprints SPN ObjectId in customer&apos;s tenant..
        /// </summary>
        internal static string BlueprintSpnObjectIdNotFound {
            get {
                return ResourceManager.GetString("BlueprintSpnObjectIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t deserialize the JSON file &apos;{0}&apos;.  &apos;{1}&apos;.
        /// </summary>
        internal static string CantDeserializeJson {
            get {
                return ResourceManager.GetString("CantDeserializeJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create artifact &apos;{0}&apos;.
        /// </summary>
        internal static string CreateArtifactShouldProcessString {
            get {
                return ResourceManager.GetString("CreateArtifactShouldProcessString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create blueprint assignment &apos;{0}&apos;.
        /// </summary>
        internal static string CreateAssignmentShouldProcessString {
            get {
                return ResourceManager.GetString("CreateAssignmentShouldProcessString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete blueprint assignment &apos;{0}&apos;.
        /// </summary>
        internal static string DeleteAssignmentShouldProcessString {
            get {
                return ResourceManager.GetString("DeleteAssignmentShouldProcessString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting folder contents..
        /// </summary>
        internal static string DeleteBlueprintFolderContentsContinueMessage {
            get {
                return ResourceManager.GetString("DeleteBlueprintFolderContentsContinueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder &apos;{0}&apos; already exists. This operation will replace contents of the folder with specified blueprint and its artifacts. Would you like to continue?.
        /// </summary>
        internal static string DeleteBlueprintFolderContentsProcessString {
            get {
                return ResourceManager.GetString("DeleteBlueprintFolderContentsProcessString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwriting the output file..
        /// </summary>
        internal static string OverwriteExistingOutputFileContinueMessage {
            get {
                return ResourceManager.GetString("OverwriteExistingOutputFileContinueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to overwrite the output file &apos;{0}&apos;.json?.
        /// </summary>
        internal static string OverwriteExistingOutputFileProcessMessage {
            get {
                return ResourceManager.GetString("OverwriteExistingOutputFileProcessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwriting unpublished blueprint and artifacts..
        /// </summary>
        internal static string OverwriteUnpublishedChangesContinueMessage {
            get {
                return ResourceManager.GetString("OverwriteUnpublishedChangesContinueMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Blueprint &apos;{0}&apos; already exists. This operation will overwrite any unpublished changes in the blueprint &apos;{1}&apos; and its artifacts. Would you like to continue?.
        /// </summary>
        internal static string OverwriteUnpublishedChangesProcessMessage {
            get {
                return ResourceManager.GetString("OverwriteUnpublishedChangesProcessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Publish blueprint &apos;{0}&apos;.
        /// </summary>
        internal static string PublishBlueprintShouldProcessString {
            get {
                return ResourceManager.GetString("PublishBlueprintShouldProcessString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not register the resource provider &apos;{0}&apos;.
        /// </summary>
        internal static string ResourceProviderRegistrationFailed {
            get {
                return ResourceManager.GetString("ResourceProviderRegistrationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected error occurred while checking if blueprint already exists. Try again in a few minutes. &apos;{0}&apos;.
        /// </summary>
        internal static string UnexpectedErrorWhileCheckingIfBlueprintExists {
            get {
                return ResourceManager.GetString("UnexpectedErrorWhileCheckingIfBlueprintExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update artifact &apos;{0}&apos;.
        /// </summary>
        internal static string UpdateArtifactShouldProcessString {
            get {
                return ResourceManager.GetString("UpdateArtifactShouldProcessString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update blueprint assignment &apos;{0}&apos;.
        /// </summary>
        internal static string UpdateAssignmentShouldProcessString {
            get {
                return ResourceManager.GetString("UpdateAssignmentShouldProcessString", resourceCulture);
            }
        }
    }
}