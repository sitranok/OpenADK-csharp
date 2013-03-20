// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;

namespace OpenADK.Library.au.Common{

/// <summary>A CountriesOfCitizenship</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class CountriesOfCitizenship : SifKeyedList<Country>
{
	/// <summary>
	/// Creates an instance of a CountriesOfCitizenship
	/// </summary>
	public CountriesOfCitizenship() : base ( CommonDTD.COUNTRIESOFCITIZENSHIP ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="countryOfCitizenship">A person's country of citizenship.</param>
	///
	public CountriesOfCitizenship( Country countryOfCitizenship ) : base( CommonDTD.COUNTRIESOFCITIZENSHIP )
	{
		this.SafeAddChild( CommonDTD.COUNTRIESOFCITIZENSHIP_COUNTRYOFCITIZENSHIP, countryOfCitizenship );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CountriesOfCitizenship( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.COUNTRIESOFCITIZENSHIP_COUNTRYOFCITIZENSHIP }; }
	}

	///<summary>Adds the value of the <c>&lt;CountryOfCitizenship&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Country&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setCountryOfCitizenship</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddCountryOfCitizenship</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddCountryOfCitizenship( CountryCode Value ) {
		AddChild( CommonDTD.COUNTRIESOFCITIZENSHIP_COUNTRYOFCITIZENSHIP, new Country( Value ) );
	}

}}
