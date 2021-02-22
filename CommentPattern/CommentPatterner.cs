using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace CommentPattern
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("1c476885-8e72-48c7-9731-d0a26f37a89e")]
    public class CommentPatterner : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentPatterner"/> class.
        /// </summary>
        public CommentPatterner() : base(null)
        {
            this.Caption = "CommentPatterner";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new CommentPatternerControl();
        }
    }
}
