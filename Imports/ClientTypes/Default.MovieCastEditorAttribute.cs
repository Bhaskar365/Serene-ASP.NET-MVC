using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene1.Default
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serene1.Default.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}

