// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SessionActivity
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SessionActivity object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	[Serializable]
	public class SessionActivity : SifEnum
	{
	/// <summary>Homework ("Homework")</summary>
	public static readonly SessionActivity HOMEWORK = new SessionActivity("Homework");

	/// <summary>Test ("Test")</summary>
	public static readonly SessionActivity TEST = new SessionActivity("Test");

	/// <summary>Exam ("Exam")</summary>
	public static readonly SessionActivity EXAM = new SessionActivity("Exam");

	///<summary>Wrap an arbitrary string value in a SessionActivity object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SessionActivity Wrap( String wrappedValue ) {
		return new SessionActivity( wrappedValue );
	}

	private SessionActivity( string enumDefValue ) : base( enumDefValue ) {}
	}
}
