// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Hrfin
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SpecialAmountType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SpecialAmountType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class SpecialAmountType : SifEnum
	{
	/// <summary>Other ("5")</summary>
	public static readonly SpecialAmountType OTHER = new SpecialAmountType("5");

	/// <summary>Early Intervention ("3")</summary>
	public static readonly SpecialAmountType EARLY_INTERVENTION = new SpecialAmountType("3");

	/// <summary>Institutionalized Children ("4")</summary>
	public static readonly SpecialAmountType INSTITUTIONALIZED = new SpecialAmountType("4");

	/// <summary>Transportation ("2")</summary>
	public static readonly SpecialAmountType TRANSPORTATION = new SpecialAmountType("2");

	/// <summary>Special Education ("1")</summary>
	public static readonly SpecialAmountType SPECIAL_ID = new SpecialAmountType("1");

	///<summary>Wrap an arbitrary string value in a SpecialAmountType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SpecialAmountType Wrap( String wrappedValue ) {
		return new SpecialAmountType( wrappedValue );
	}

	private SpecialAmountType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
