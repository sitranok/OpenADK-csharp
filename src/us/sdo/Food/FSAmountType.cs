// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Food
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FSAmountType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FSAmountType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class FSAmountType : SifEnum
	{
	/// <summary>Value ("Value")</summary>
	public static readonly FSAmountType ACTUAL_VALUE = new FSAmountType("Value");

	/// <summary>Check ("Check")</summary>
	public static readonly FSAmountType CHECK = new FSAmountType("Check");

	/// <summary>Lunch Credit ("LunchCredit")</summary>
	public static readonly FSAmountType LUNCHCREDIT = new FSAmountType("LunchCredit");

	/// <summary>Cash ("Cash")</summary>
	public static readonly FSAmountType CASH = new FSAmountType("Cash");

	/// <summary>Breakfast Credit ("BreakfastCredit")</summary>
	public static readonly FSAmountType BREAKFASTCREDIT = new FSAmountType("BreakfastCredit");

	/// <summary>ACH ("ACH")</summary>
	public static readonly FSAmountType ACH = new FSAmountType("ACH");

	/// <summary>Credit Card ("CreditCard")</summary>
	public static readonly FSAmountType CREDITCARD = new FSAmountType("CreditCard");

	///<summary>Wrap an arbitrary string value in a FSAmountType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FSAmountType Wrap( String wrappedValue ) {
		return new FSAmountType( wrappedValue );
	}

	private FSAmountType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
