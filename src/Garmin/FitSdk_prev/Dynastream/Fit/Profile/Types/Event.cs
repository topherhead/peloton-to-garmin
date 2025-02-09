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

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile Event type as an enum
    /// </summary>
    public enum Event : byte
    {
        Timer = 0,
        Workout = 3,
        WorkoutStep = 4,
        PowerDown = 5,
        PowerUp = 6,
        OffCourse = 7,
        Session = 8,
        Lap = 9,
        CoursePoint = 10,
        Battery = 11,
        VirtualPartnerPace = 12,
        HrHighAlert = 13,
        HrLowAlert = 14,
        SpeedHighAlert = 15,
        SpeedLowAlert = 16,
        CadHighAlert = 17,
        CadLowAlert = 18,
        PowerHighAlert = 19,
        PowerLowAlert = 20,
        RecoveryHr = 21,
        BatteryLow = 22,
        TimeDurationAlert = 23,
        DistanceDurationAlert = 24,
        CalorieDurationAlert = 25,
        Activity = 26,
        FitnessEquipment = 27,
        Length = 28,
        UserMarker = 32,
        SportPoint = 33,
        Calibration = 36,
        FrontGearChange = 42,
        RearGearChange = 43,
        RiderPositionChange = 44,
        ElevHighAlert = 45,
        ElevLowAlert = 46,
        CommTimeout = 47,
        RadarThreatAlert = 75,
        Invalid = 0xFF


    }
}

