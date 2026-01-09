using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene1.Default
{
    public partial class MovieCastEditDialogAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene1.Default.MovieCastEditDialog";

        public MovieCastEditDialogAttribute()
            : base(Key)
        {
        }
    }
}

