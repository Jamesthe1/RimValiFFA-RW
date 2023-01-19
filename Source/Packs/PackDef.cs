﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace RimValiFFARW.Packs
{
    /// <summary>
    ///     In RimVali, the Avali can form <see cref="Pack"/>s, and these may have a set of different attributes, buffs and debuffs.
    ///     To realize this, this <see cref="Def"/> class describes those attributes.
    /// </summary>
    public class PackDef : Def
    {
        public List<HediffDef> memberHediffs = new List<HediffDef>();
        public Type packWorkerType = typeof(PackWorker);

        public int minSize = 2;

        public int maxSize = 5;

        /// <summary>
        ///     The maximum size of a <see cref="Pack"/>
        /// </summary>
        public int MaxSize => maxSize;

        /// <summary>
        ///     The minimum size of a <see cref="Pack"/>
        /// </summary>
        public int MinSize => minSize;

        /// <summary>
        ///     Creates a new object of type <see cref="PackWorker"/> with the type as stated in the def file at <see cref="packWorkerType"/>
        /// </summary>
        public PackWorker GetNewPackWorker => packWorkerType.GetConstructor(new Type[] { typeof(PackDef) }).Invoke(new object[] { this }) as PackWorker;
    }
}
