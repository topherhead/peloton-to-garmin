#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2020 Garmin Canada Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.40Release
// Tag = production/akw/21.40.00-0-g813c158
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynastream.Fit
{
    public class Accumulator
    {
        List<AccumulatedField> accumulatedFields;

        public Accumulator()
        {
            accumulatedFields = new List<AccumulatedField>();
        }

        public void Set(int mesgNum, int destFieldNum, long value)
        {
            AccumulatedField accumField = null;
            int i;

            for (i = 0; i < accumulatedFields.Count; i++)
            {
                accumField = accumulatedFields[i];

                if ((accumField.mesgNum == mesgNum) && (accumField.destFieldNum == destFieldNum))
                    break;
            }

            if (i == accumulatedFields.Count)
            {
                accumField = new AccumulatedField(mesgNum, destFieldNum);
                accumulatedFields.Add(accumField);
            }

            accumField.Set(value);
        }

        public long Accumulate(int mesgNum, int destFieldNum, long value, int bits)
        {
            AccumulatedField accumField = null;
            int i;
            for (i = 0; i < accumulatedFields.Count; i++)
            {
                accumField = accumulatedFields[i];

                if ((accumField.mesgNum == mesgNum) && (accumField.destFieldNum == destFieldNum))
                    break;
            }

            if (i == accumulatedFields.Count)
            {
                accumField = new AccumulatedField(mesgNum, destFieldNum);
                accumulatedFields.Add(accumField);
            }

            return accumField.Accumulate(value, bits);
        }
    }
}
