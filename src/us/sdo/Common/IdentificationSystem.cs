// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an IdentificationSystem
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an IdentificationSystem object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class IdentificationSystem : SifEnum
	{
	/// <summary>NCES number for a LEA (deprecated) ("19")</summary>
	public static readonly IdentificationSystem SIF1X_NCES_NUMBER_FOR_A_LEA = new IdentificationSystem("19");

	/// <summary>SEA number for LEA (deprecated) ("17 ")</summary>
	public static readonly IdentificationSystem SIF1X_SEA_NUMBER_FOR_LEA = new IdentificationSystem("17 ");

	/// <summary>Dunn and Bradstreet number (e.g., DUNS number) ("0276")</summary>
	public static readonly IdentificationSystem DUNS_NUMBER = new IdentificationSystem("0276");

	/// <summary>SEA number for school (deprecated) ("16")</summary>
	public static readonly IdentificationSystem SIF1X_SEA_NUMBER_FOR_SCHOOL = new IdentificationSystem("16");

	/// <summary>National Center for Education Statistics (NCES) Common Core of Data (CCD) number for PreK-12 institutions, 12-digit codes available from NCES ("77")</summary>
	public static readonly IdentificationSystem SIF1x_NCES_CCD = new IdentificationSystem("77");

	/// <summary>College Board/ACT code set of PK-grade 12 institutions ("0175")</summary>
	public static readonly IdentificationSystem ACT_INST_CODE = new IdentificationSystem("0175");

	/// <summary>Other ("99 ")</summary>
	public static readonly IdentificationSystem SIF1X_OTHER = new IdentificationSystem("99 ");

	/// <summary>College Board/ACT code set of PK-grade 12 institutions (deprecated) ("14 ")</summary>
	public static readonly IdentificationSystem SIF1X_ACT_INST_CODE = new IdentificationSystem("14 ");

	/// <summary>NCES number for school (deprecated) ("18")</summary>
	public static readonly IdentificationSystem SIF1X_NCES_NUMBER_FOR_SCHOOL = new IdentificationSystem("18");

	/// <summary>FederalID Number ("0264")</summary>
	public static readonly IdentificationSystem FEDERAL_ID = new IdentificationSystem("0264");

	/// <summary>State or province assigned number ("75")</summary>
	public static readonly IdentificationSystem SIF1x_STATE_ASSIGNED = new IdentificationSystem("75");

	/// <summary>Other federally assigned number ("0764")</summary>
	public static readonly IdentificationSystem OTHER_FEDERAL = new IdentificationSystem("0764");

	/// <summary>College Board and ACT 6-digit list of secondary educational institutions, available from ETS or ACT (see the SIF Specification) ("78")</summary>
	public static readonly IdentificationSystem SIF1x_ACT = new IdentificationSystem("78");

	/// <summary>LEA number for school (deprecated) ("15")</summary>
	public static readonly IdentificationSystem SIF1X_LEA_NUMBER_FOR_SCHOOL = new IdentificationSystem("15");

	/// <summary>Other ("9999")</summary>
	public static readonly IdentificationSystem OTHER = new IdentificationSystem("9999");

	/// <summary>Dunn and Broadstreet number (deprecated) ("25")</summary>
	public static readonly IdentificationSystem SIF1X_DUNS_NUMBER = new IdentificationSystem("25");

	/// <summary>Local school district or jurisdiction number ("76")</summary>
	public static readonly IdentificationSystem SIF1x_LOCAL_NUMBER = new IdentificationSystem("76");

	/// <summary>Other agency number (e.g., Roman Catholic diocese or association member) (deprecated) ("20")</summary>
	public static readonly IdentificationSystem SIF1X_OTHER_AGENCY_NUMBER = new IdentificationSystem("20");

	///<summary>Wrap an arbitrary string value in an IdentificationSystem object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static IdentificationSystem Wrap( String wrappedValue ) {
		return new IdentificationSystem( wrappedValue );
	}

	private IdentificationSystem( string enumDefValue ) : base( enumDefValue ) {}
	}
}
