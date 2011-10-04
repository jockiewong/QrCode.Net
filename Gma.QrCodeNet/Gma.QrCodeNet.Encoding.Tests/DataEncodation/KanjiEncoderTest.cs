﻿using System.Collections.Generic;
using Gma.QrCodeNet.Encoding.DataEncodation;
using NUnit.Framework;

namespace Gma.QrCodeNet.Encoding.Tests.DataEncodation
{
	[TestFixture]
	public class KanjiEncoderTest : EncoderTestBase
	{
		[Test, TestCaseSource(typeof(KanjiEncoderTestCaseFactory), "TestCasesFromReferenceImplementation")]
        public override void Test_against_reference_implementation(string inputString, int version, IEnumerable<bool> expected)
        {
            base.Test_against_reference_implementation(inputString, version, expected);
        }

        [Test, TestCaseSource(typeof(KanjiEncoderTestCaseFactory), "TestCasesFromCsvFile")]
        public override void Test_against_csv_DataSet(string inputString, int version, IEnumerable<bool> expected)
        {
            base.Test_against_csv_DataSet(inputString, version, expected);
        }

        protected override EncoderBase CreateEncoder(int version)
        {
            return new KanjiEncoder(version);
        }
        
        //[Test]
        public void Generate()
        {
            new KanjiEncoderTestCaseFactory().GenerateTestDataSet();
        }
	}
}
