﻿using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatcher.DotNetPatcher
{
    public abstract class iDeobfL
    {
        public abstract string Version { get; } //Example "DotNetPatcher v4.5.9.0"
        public abstract string Name { get; } //Example Cflow
        public abstract int Excute(ModuleDef module); //Deobf the module
    }
}
