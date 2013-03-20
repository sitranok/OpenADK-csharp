// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AttendanceSourceType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AttendanceSourceType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	[Serializable]
	public class AttendanceSourceType : SifEnum
	{
	/// <summary>Human other than workforce member ("HU")</summary>
	public static readonly AttendanceSourceType HU_HUMAN_OT_THAN_WORKFORCE = new AttendanceSourceType("HU");

	/// <summary>Biometric device ("BIO")</summary>
	public static readonly AttendanceSourceType BIO_BIOMETRIC_DEVICE = new AttendanceSourceType("BIO");

	/// <summary>Workforce Member ("WF")</summary>
	public static readonly AttendanceSourceType WF_WORKFORCE_MEMBER = new AttendanceSourceType("WF");

	/// <summary>Other non-human input source ("OT")</summary>
	public static readonly AttendanceSourceType OT_OT_NONHUMAN_INPUT = new AttendanceSourceType("OT");

	///<summary>Wrap an arbitrary string value in an AttendanceSourceType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AttendanceSourceType Wrap( String wrappedValue ) {
		return new AttendanceSourceType( wrappedValue );
	}

	private AttendanceSourceType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
