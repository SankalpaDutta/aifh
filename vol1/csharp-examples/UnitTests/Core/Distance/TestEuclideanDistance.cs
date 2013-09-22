﻿// Artificial Intelligence for Humans
// Volume 1: Fundamental Algorithms
// C# Version
// http://www.aifh.org
// http://www.jeffheaton.com
//
// Code repository:
// https://github.com/jeffheaton/aifh
//
// Copyright 2013 by Jeff Heaton
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// For more information on Heaton Research copyrights, licenses
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//

using AIFH_Vol1.Core.Distance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core.Distance
{
    /// <summary>
    /// Summary description for TestEuclideanDistance
    /// </summary>
    [TestClass]
    public class TestEuclideanDistance
    {
        [TestMethod]
        public void TestDistanceCalc()
        {
            ICalculateDistance calc = new EuclideanDistance();
            double[] pos1 = { 0.5, 1.0, 2.5 };
            double[] pos2 = { 0.1, 2.0, -2.5 };

            Assert.AreEqual(5.1146, calc.Calculate(pos1, pos2), 0.001);
        }
    }
}
