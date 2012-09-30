// Copyright (c) 2012, Francis Gagné
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//     * Redistributions of source code must retain the above copyright
//       notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the <organization> nor the
//       names of its contributors may be used to endorse or promote products
//       derived from this software without specific prior written permission.

namespace FraGag.Compression.PrsFrontend
{
    using System.Windows.Forms; // for XML docs

    /// <summary>
    /// Defines the possible modes for a <see cref="FileSelector"/>.
    /// </summary>
    public enum FileSelectorMode
    {
        /// <summary>
        /// The <see cref="FileSelector"/> will use an <see cref="OpenFileDialog"/>.
        /// </summary>
        Open,

        /// <summary>
        /// The <see cref="FileSelector"/> will use a <see cref="SaveFileDialog"/>.
        /// </summary>
        Save
    }
}
