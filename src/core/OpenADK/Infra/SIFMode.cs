// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.Infra
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SIFMode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SIFMode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class SIFMode : SifEnum
	{
	/// <summary>Pull ("Pull")</summary>
	public static readonly SIFMode PULL = new SIFMode("Pull");

	/// <summary>Push ("Push")</summary>
	public static readonly SIFMode PUSH = new SIFMode("Push");

	///<summary>Wrap an arbitrary string value in a SIFMode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SIFMode Wrap( String wrappedValue ) {
		return new SIFMode( wrappedValue );
	}

	private SIFMode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
