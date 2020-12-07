﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fortnox.NET.Models.AbsenceTransactions
{
    public enum CauseCode
    {
        /// <summary>
        /// Arbetsskada
        /// </summary>
        [EnumMember(Value = "ASK")]
        ASK,

        /// <summary>
        /// Arbetstidsförkortning
        /// </summary>
        [EnumMember(Value = "ATF")]
        ATF,

        /// <summary>
        /// Föräldraledig
        /// </summary>
        [EnumMember(Value = "FPE")]
        FPE,

        /// <summary>
        /// Frånvaro övrigt
        /// </summary>
        [EnumMember(Value = "FRA")]
        FRA,

        /// <summary>
        /// Graviditetspenning
        /// </summary>
        [EnumMember(Value = "HAV")]
        HAV,

        /// <summary>
        /// Kompledig
        /// </summary>
        [EnumMember(Value = "KOM")]
        KOM,

        /// <summary>
        /// Militärtjänst (max 60 dagar)
        /// </summary>
        [EnumMember(Value = "MIL")]
        MIL,

        /// <summary>
        /// Närståendevård
        /// </summary>
        [EnumMember(Value = "NAR")]
        NAR,

        /// <summary>
        /// Sjuk-OB 1
        /// </summary>
        [EnumMember(Value = "OS1")]
        OS1,

        /// <summary>
        /// Sjuk-OB 2
        /// </summary>
        [EnumMember(Value = "OS2")]
        OS2,

        /// <summary>
        /// Sjuk-OB 3
        /// </summary>
        [EnumMember(Value = "OS3")]
        OS3,

        /// <summary>
        /// Sjuk-OB 4
        /// </summary>
        [EnumMember(Value = "OS4")]
        OS4,

        /// <summary>
        /// Sjuk-OB 5
        /// </summary>
        [EnumMember(Value = "OS5")]
        OS5,

        /// <summary>
        /// Pappadagar
        /// </summary>
        [EnumMember(Value = "PAP")]
        PAP,

        /// <summary>
        /// Permission
        /// </summary>
        [EnumMember(Value = "PEM")]
        PEM,

        /// <summary>
        /// Permitterad
        /// </summary>
        [EnumMember(Value = "PER")]
        PER,

        /// <summary>
        /// Semester
        /// </summary>
        [EnumMember(Value = "SEM")]
        SEM,

        /// <summary>
        /// Sjukfrånvaro
        /// </summary>
        [EnumMember(Value = "SJK")]
        SJK,

        /// <summary>
        /// Smittbärare
        /// </summary>
        [EnumMember(Value = "SMB")]
        SMB,

        /// <summary>
        /// Svenska för invandrare
        /// </summary>
        [EnumMember(Value = "SVE")]
        SVE,

        /// <summary>
        /// Tjänstledig
        /// </summary>
        [EnumMember(Value = "TJL")]
        TJL,

        /// <summary>
        /// Facklig utbildning
        /// </summary>
        [EnumMember(Value = "UTB")]
        UTB,

        /// <summary>
        /// Vård av barn
        /// </summary>
        [EnumMember(Value = "VAB")]
        VAB,
    }
}
