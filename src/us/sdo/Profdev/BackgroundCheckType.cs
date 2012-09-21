// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Profdev
{
	///<summary>
	/// Defines the set of values that can be specified whenever a BackgroundCheckType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a BackgroundCheckType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class BackgroundCheckType : SifEnum
	{
	/// <summary>Other ("9999")</summary>
	public static readonly BackgroundCheckType OTHER = new BackgroundCheckType("9999");

	/// <summary>Credentials ("1423")</summary>
	public static readonly BackgroundCheckType CREDENTIALS = new BackgroundCheckType("1423");

	/// <summary>Personal references ("1422")</summary>
	public static readonly BackgroundCheckType PERSONAL_REFERENCES = new BackgroundCheckType("1422");

	/// <summary>Criminal records ("1420")</summary>
	public static readonly BackgroundCheckType CRIMINAL_RECORDS = new BackgroundCheckType("1420");

	/// <summary>Previous employment records ("1421")</summary>
	public static readonly BackgroundCheckType EMPLOYMENT_RECORDS = new BackgroundCheckType("1421");

	///<summary>Wrap an arbitrary string value in a BackgroundCheckType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static BackgroundCheckType Wrap( String wrappedValue ) {
		return new BackgroundCheckType( wrappedValue );
	}

	private BackgroundCheckType( string enumDefValue ) : base( enumDefValue ) {}
	}
}