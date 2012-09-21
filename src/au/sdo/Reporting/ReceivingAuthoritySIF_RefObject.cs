// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Reporting
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ReceivingAuthoritySIF_RefObject
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ReceivingAuthoritySIF_RefObject object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class ReceivingAuthoritySIF_RefObject : SifEnum
	{
	/// <summary>ReportAuthorityInfo ("ReportAuthorityInfo")</summary>
	public static readonly ReceivingAuthoritySIF_RefObject REPORTAUTHORITYINFO = new ReceivingAuthoritySIF_RefObject("ReportAuthorityInfo");

	///<summary>Wrap an arbitrary string value in a ReceivingAuthoritySIF_RefObject object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ReceivingAuthoritySIF_RefObject Wrap( String wrappedValue ) {
		return new ReceivingAuthoritySIF_RefObject( wrappedValue );
	}

	private ReceivingAuthoritySIF_RefObject( string enumDefValue ) : base( enumDefValue ) {}
	}
}