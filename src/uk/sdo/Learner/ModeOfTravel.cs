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
	/// Defines the set of values that can be specified whenever a ModeOfTravel
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ModeOfTravel object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class ModeOfTravel : SifEnum
	{
	/// <summary>Cycle ("CYC")</summary>
	public static readonly ModeOfTravel CYCLE = new ModeOfTravel("CYC");

	/// <summary>Dedicated school bus ("DSB")</summary>
	public static readonly ModeOfTravel DEDICATED_SCHOOL_BUS = new ModeOfTravel("DSB");

	/// <summary>Other ("OTH")</summary>
	public static readonly ModeOfTravel OTHER = new ModeOfTravel("OTH");

	/// <summary>London Underground ("LUL")</summary>
	public static readonly ModeOfTravel LONDON_UNDERGROUND = new ModeOfTravel("LUL");

	/// <summary>Public service bus ("PSB")</summary>
	public static readonly ModeOfTravel PUBLIC_SERVICE_BUS = new ModeOfTravel("PSB");

	/// <summary>Taxi ("TXI")</summary>
	public static readonly ModeOfTravel TAXI = new ModeOfTravel("TXI");

	/// <summary>Car Share (with a child/children from a different household) ("CRS")</summary>
	public static readonly ModeOfTravel CAR_SHARE = new ModeOfTravel("CRS");

	/// <summary>Train ("TRN")</summary>
	public static readonly ModeOfTravel TRAIN = new ModeOfTravel("TRN");

	/// <summary>Metro/Tram/Light Rail ("MTL")</summary>
	public static readonly ModeOfTravel METRO_TRAM_LIGHT_RAIL = new ModeOfTravel("MTL");

	/// <summary>Walk ("WLK")</summary>
	public static readonly ModeOfTravel WALK = new ModeOfTravel("WLK");

	/// <summary>Bus (type not known) ("BNK")</summary>
	public static readonly ModeOfTravel BUS_TYPE_NOT_KNOWN = new ModeOfTravel("BNK");

	/// <summary>Car/Van ("CAR")</summary>
	public static readonly ModeOfTravel CAR_VAN = new ModeOfTravel("CAR");

	///<summary>Wrap an arbitrary string value in a ModeOfTravel object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ModeOfTravel Wrap( String wrappedValue ) {
		return new ModeOfTravel( wrappedValue );
	}

	private ModeOfTravel( string enumDefValue ) : base( enumDefValue ) {}
	}
}
