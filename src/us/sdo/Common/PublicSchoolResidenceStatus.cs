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
	/// Defines the set of values that can be specified whenever a PublicSchoolResidenceStatus
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a PublicSchoolResidenceStatus object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class PublicSchoolResidenceStatus : SifEnum
	{
	/// <summary>Resident of an administrative unit that crosses state boundaries--The individual's legal residence is in an administrative unit that crosses state boundaries. ("1655")</summary>
	public static readonly PublicSchoolResidenceStatus MULTI_STATE = new PublicSchoolResidenceStatus("1655");

	/// <summary>Resident of another state ("1656")</summary>
	public static readonly PublicSchoolResidenceStatus C0598_1656 = new PublicSchoolResidenceStatus("1656");

	/// <summary>Resident of an administrative unit that crosses state boundaries ("1655")</summary>
	public static readonly PublicSchoolResidenceStatus C0598_1655 = new PublicSchoolResidenceStatus("1655");

	/// <summary>Resident of this state, but not of this administrative unit ("1654")</summary>
	public static readonly PublicSchoolResidenceStatus C0598_1654 = new PublicSchoolResidenceStatus("1654");

	/// <summary>Resident of administrative unit, but of other school attendance area ("1653")</summary>
	public static readonly PublicSchoolResidenceStatus C0598_1653 = new PublicSchoolResidenceStatus("1653");

	/// <summary>Resident of administrative unit and usual school attendance area ("1652")</summary>
	public static readonly PublicSchoolResidenceStatus C0598_1652 = new PublicSchoolResidenceStatus("1652");

	/// <summary>Resident of administrative unit, but of other school attendance area--The individual's legal residence is within the administrative unit, but not within the attendance area of the school he or she attends. ("1653")</summary>
	public static readonly PublicSchoolResidenceStatus OTHER_SCHOOL = new PublicSchoolResidenceStatus("1653");

	/// <summary>Resident of administrative unit and usual school attendance area--The individual's legal residence is within the administrative unit and the attendance area of the school he or she attends. ("1652")</summary>
	public static readonly PublicSchoolResidenceStatus RESIDENT = new PublicSchoolResidenceStatus("1652");

	/// <summary>Resident of another state--The individual's legal residence is in a state other than the state in which his or her school's administrative unit resides. ("1656")</summary>
	public static readonly PublicSchoolResidenceStatus OTHER_STATE = new PublicSchoolResidenceStatus("1656");

	/// <summary>Resident of this state, but not of this administrative unit--The individual's legal residence is outside the administrative unit of the school he or she attends. ("1654")</summary>
	public static readonly PublicSchoolResidenceStatus OTHER_UNIT = new PublicSchoolResidenceStatus("1654");

	///<summary>Wrap an arbitrary string value in a PublicSchoolResidenceStatus object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static PublicSchoolResidenceStatus Wrap( String wrappedValue ) {
		return new PublicSchoolResidenceStatus( wrappedValue );
	}

	private PublicSchoolResidenceStatus( string enumDefValue ) : base( enumDefValue ) {}
	}
}
