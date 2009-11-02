﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Encog.Persist.Attributes;

namespace Encog.Normalize.Input
{
    /// <summary>
    /// An input field based on a CSV file.
    /// </summary>
    [EGReferenceable]
    public class InputFieldCSV : BasicInputField
    {
        /// <summary>
        /// The file to read.
        /// </summary>
        private String file;

        /// <summary>
        /// The CSV column represented by this field.
        /// </summary>
        [EGAttribute]
        private int offset;

        /// <summary>
        /// Construct an InputFieldCSV with the default constructor.  This is mainly
        /// used for reflection.
        /// </summary>
        public InputFieldCSV()
        {

        }

        /// <summary>
        /// Construct a input field for a CSV file.
        /// </summary>
        /// <param name="usedForNetworkInput">True if this field is used for actual 
        /// input to the neural network, as opposed to segregation only.</param>
        /// <param name="file">The tile to read.</param>
        /// <param name="offset">The CSV file column to read.</param>
        public InputFieldCSV(bool usedForNetworkInput, String file,
                 int offset)
        {
            this.file = file;
            this.offset = offset;
            UsedForNetworkInput = usedForNetworkInput;
        }

        /// <summary>
        /// The file being read.
        /// </summary>
        public String File
        {
            get
            {
                return this.file;
            }
        }

        /// <summary>
        /// The column in this CSV file to read.
        /// </summary>
        public int Offset
        {
            get
            {
                return this.offset;
            }
        }
    }
}