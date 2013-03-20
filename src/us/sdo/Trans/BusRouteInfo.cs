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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Trans{

/// <summary>This object contains all of the information about a bus route</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class BusRouteInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a BusRouteInfo
	/// </summary>
	public BusRouteInfo() : base( Adk.SifVersion, TransDTD.BUSROUTEINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies this bus route.</param>
	///<param name="busInfoRefId">The bus associated with this route</param>
	///<param name="routeNumber">A unique identifier for the route. It may contain any printable ASCII character. For instance, you may have route 16AM in the morning and a 16PM in the afternoon.</param>
	///<param name="routeType">The type of route.</param>
	///
	public BusRouteInfo( string refId, string busInfoRefId, string routeNumber, RouteType routeType ) : base( Adk.SifVersion, TransDTD.BUSROUTEINFO )
	{
		this.RefId = refId;
		this.BusInfoRefId = busInfoRefId;
		this.RouteNumber = routeNumber;
		this.SetRouteType( routeType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected BusRouteInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { TransDTD.BUSROUTEINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies this bus route."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BusInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>BusInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The bus associated with this route"</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;BusInfoRefId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string BusInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_BUSINFOREFID ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_BUSINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>RouteNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A unique identifier for the route. It may contain any printable ASCII character. For instance, you may have route 16AM in the morning and a 16PM in the afternoon."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string RouteNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_ROUTENUMBER ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_ROUTENUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteType&gt;</c> element.
	/// </summary>
	/// <value> The <c>RouteType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The type of route."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string RouteType
	{
		get
		{ 
			return GetFieldValue( TransDTD.BUSROUTEINFO_ROUTETYPE );
		}
		set
		{
			SetField( TransDTD.BUSROUTEINFO_ROUTETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;RouteType&gt;</c> element.
	/// </summary>
	/// <param name="val">A RouteType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The type of route."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetRouteType( RouteType val )
	{
		SetField( TransDTD.BUSROUTEINFO_ROUTETYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MaximumLoad&gt;</c> element.
	/// </summary>
	/// <value> The <c>MaximumLoad</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The maximum number of students who are on the bus at any point along this route."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public int? MaximumLoad
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_MAXIMUMLOAD ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_MAXIMUMLOAD, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Short explanation of the route. It may be used to designate an area, or used to color-code bus routes (the "orange" route)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">Code that specifies what type of name this is.  If unsure, use 04.</param>
	/// <param name="LastName">The last name.</param>
	/// <param name="FirstName">The first name.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Name</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetName( NameType Type, string LastName, string FirstName ) {
		RemoveChild( TransDTD.BUSROUTEINFO_NAME);
		AddChild( TransDTD.BUSROUTEINFO_NAME, new Name( Type, LastName, FirstName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Name of the driver who drives this route."</para>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( TransDTD.BUSROUTEINFO_NAME);
		}
		set
		{
			RemoveChild( TransDTD.BUSROUTEINFO_NAME);
			if( value != null)
			{
				AddChild( TransDTD.BUSROUTEINFO_NAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteDurationLoaded&gt;</c> element.
	/// </summary>
	/// <value> The <c>RouteDurationLoaded</c> element of this object.</value>
	/// <remarks>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;RouteDurationLoaded&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public TimeSpan? RouteDurationLoaded
	{
		get
		{
			return (TimeSpan?) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_ROUTEDURATIONLOADED ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_ROUTEDURATIONLOADED, new SifDuration( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteDurationTotal&gt;</c> element.
	/// </summary>
	/// <value> The <c>RouteDurationTotal</c> element of this object.</value>
	/// <remarks>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;RouteDurationTotal&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public TimeSpan? RouteDurationTotal
	{
		get
		{
			return (TimeSpan?) GetSifSimpleFieldValue( TransDTD.BUSROUTEINFO_ROUTEDURATIONTOTAL ) ;
		}
		set
		{
			SetFieldValue( TransDTD.BUSROUTEINFO_ROUTEDURATIONTOTAL, new SifDuration( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;RouteDistanceLoaded&gt;</c> element.</summary>
	/// <param name="Unit">Units used in the odometer reading.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Distance&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setRouteDistanceLoaded</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>RouteDistanceLoaded</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetRouteDistanceLoaded( DistanceUnit Unit, decimal? Value ) {
		RemoveChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCELOADED);
		AddChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCELOADED, new Distance( Unit, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteDistanceLoaded&gt;</c> element.
	/// </summary>
	/// <value> A Distance </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Refers to the distance the bus drives when at least one student is riding the bus."</para>
	/// <para>This null is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering nulls of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;RouteDistanceLoaded&gt;</description></item>
	/// </list>
	/// <para>To remove the <c>Distance</c>, set <c>RouteDistanceLoaded</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public Distance RouteDistanceLoaded
	{
		get
		{
			return (Distance)GetChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCELOADED);
		}
		set
		{
			RemoveChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCELOADED);
			if( value != null)
			{
				AddChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCELOADED, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;RouteDistanceTotal&gt;</c> element.</summary>
	/// <param name="Unit">Units used in the odometer reading.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Distance&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setRouteDistanceTotal</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>RouteDistanceTotal</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetRouteDistanceTotal( DistanceUnit Unit, decimal? Value ) {
		RemoveChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCETOTAL);
		AddChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCETOTAL, new Distance( Unit, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteDistanceTotal&gt;</c> element.
	/// </summary>
	/// <value> A Distance </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Includes the total distance driven for this route including to and from garage."</para>
	/// <para>This null is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering nulls of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;RouteDistanceTotal&gt;</description></item>
	/// </list>
	/// <para>To remove the <c>Distance</c>, set <c>RouteDistanceTotal</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public Distance RouteDistanceTotal
	{
		get
		{
			return (Distance)GetChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCETOTAL);
		}
		set
		{
			RemoveChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCETOTAL);
			if( value != null)
			{
				AddChild( TransDTD.BUSROUTEINFO_ROUTEDISTANCETOTAL, value );
			}
		}
	}

}}
