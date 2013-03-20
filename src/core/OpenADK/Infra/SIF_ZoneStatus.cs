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

namespace OpenADK.Library.Infra{

/// <summary>Provides information about a SIF Zone Integration Server</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_ZoneStatus : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SIF_ZoneStatus
	/// </summary>
	public SIF_ZoneStatus() : base( Adk.SifVersion, InfraDTD.SIF_ZONESTATUS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="zoneId">
	///         The identifier for this Zone.
	///         It is the same as the SIF_SourceId that the ZIS would place in any SIF_Header that it creates.
	///       </param>
	///<param name="sifProviders">Encompasses all of the providers registered with the ZIS</param>
	///<param name="sifSubscribers">Encompasses all of the subscribers registered with the ZIS</param>
	///<param name="sifsifNodes">Encompasses all of the nodes attached to this ZIS</param>
	///<param name="sifSupportedAuthentication">Enumerates the various authentication protocols that the ZIS supports</param>
	///<param name="sifSupportedProtocols">Enumerates the various communication transport protocols that the ZIS supports</param>
	///<param name="sifSupportedVersions">Enumerates the versions of the SIF Specification that the ZIS can use when communicating with the SIF_SIFNode</param>
	///
	public SIF_ZoneStatus( string zoneId, SIF_Providers sifProviders, SIF_Subscribers sifSubscribers, SIF_SIFNodes sifsifNodes, SIF_SupportedAuthentication sifSupportedAuthentication, SIF_SupportedProtocols sifSupportedProtocols, SIF_SupportedVersions sifSupportedVersions ) : base( Adk.SifVersion, InfraDTD.SIF_ZONESTATUS )
	{
		this.ZoneId = zoneId;
		this.SIF_Providers = sifProviders;
		this.SIF_Subscribers = sifSubscribers;
		this.SIF_SIFNodes = sifsifNodes;
		this.SIF_SupportedAuthentication = sifSupportedAuthentication;
		this.SIF_SupportedProtocols = sifSupportedProtocols;
		this.SIF_SupportedVersions = sifSupportedVersions;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ZoneStatus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_ZONESTATUS_ZONEID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>ZoneId</c> attribute.
	/// </summary>
	/// <value> The <c>ZoneId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "
	///         The identifier for this Zone.
	///         It is the same as the SIF_SourceId that the ZIS would place in any SIF_Header that it creates.
	///       "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string ZoneId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ZONESTATUS_ZONEID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ZONESTATUS_ZONEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The descriptive name for the zone."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ZONESTATUS_SIF_NAME ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ZONESTATUS_SIF_NAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_Vendor&gt;</c> element.</summary>
	/// <param name="SifName">The name of the company who wrote the ZIS.</param>
	/// <param name="SifProduct">The product name assigned by the vendor to identify this ZIS.</param>
	/// <param name="SifVersion">The version of the vendor's product--not necessarily the SIF version.</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Vendor</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_Vendor</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetSIF_Vendor( string SifName, string SifProduct, string SifVersion ) {
		RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_VENDOR);
		AddChild( InfraDTD.SIF_ZONESTATUS_SIF_VENDOR, new SIF_Vendor( SifName, SifProduct, SifVersion ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Vendor&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Vendor </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Information about the vendor who wrote this ZIS"</para>
	/// <para>To remove the <c>SIF_Vendor</c>, set <c>SIF_Vendor</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Vendor SIF_Vendor
	{
		get
		{
			return (SIF_Vendor)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_VENDOR);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_VENDOR);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_VENDOR, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Icon&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Icon</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	///         HTTP URL referencing an icon for graphical representation of the ZIS/Zone.
	///         Should range from 16x16 pixels to 128x128 pixels and be of an image MIME type commonly supported by Web browsers (e.g. PNG, JPEG, GIF).
	///         Agents may optionally follow the more restrictive guidelines at [FAVICON].
	///       "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_Icon
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ZONESTATUS_SIF_ICON ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ZONESTATUS_SIF_ICON, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Providers&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Providers </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Encompasses all of the providers registered with the ZIS"</para>
	/// <para>To remove the <c>SIF_Providers</c>, set <c>SIF_Providers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Providers SIF_Providers
	{
		get
		{
			return (SIF_Providers)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_PROVIDERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_PROVIDERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_PROVIDERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Subscribers&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Subscribers </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Encompasses all of the subscribers registered with the ZIS"</para>
	/// <para>To remove the <c>SIF_Subscribers</c>, set <c>SIF_Subscribers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Subscribers SIF_Subscribers
	{
		get
		{
			return (SIF_Subscribers)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_SUBSCRIBERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_SUBSCRIBERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_SUBSCRIBERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SIFNodes&gt;</c> element.
	/// </summary>
	/// <value> A SIF_SIFNodes </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Encompasses all of the nodes attached to this ZIS"</para>
	/// <para>To remove the <c>SIF_SIFNodes</c>, set <c>SIF_SIFNodes</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_SIFNodes SIF_SIFNodes
	{
		get
		{
			return (SIF_SIFNodes)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_SIFNODES);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_SIFNODES);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_SIFNODES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_AddPublishers&gt;</c> element.
	/// </summary>
	/// <value> A SIF_AddPublishers </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_AddPublishers</c>, set <c>SIF_AddPublishers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_AddPublishers SIF_AddPublishers
	{
		get
		{
			return (SIF_AddPublishers)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_ADDPUBLISHERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_ADDPUBLISHERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_ADDPUBLISHERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SupportedAuthentication&gt;</c> element.
	/// </summary>
	/// <value> A SIF_SupportedAuthentication </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Enumerates the various authentication protocols that the ZIS supports"</para>
	/// <para>To remove the <c>SIF_SupportedAuthentication</c>, set <c>SIF_SupportedAuthentication</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_SupportedAuthentication SIF_SupportedAuthentication
	{
		get
		{
			return (SIF_SupportedAuthentication)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDAUTHENTICATION);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDAUTHENTICATION);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDAUTHENTICATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ChangePublishers&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ChangePublishers </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ChangePublishers</c>, set <c>SIF_ChangePublishers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_ChangePublishers SIF_ChangePublishers
	{
		get
		{
			return (SIF_ChangePublishers)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_CHANGEPUBLISHERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_CHANGEPUBLISHERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_CHANGEPUBLISHERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SupportedProtocols&gt;</c> element.
	/// </summary>
	/// <value> A SIF_SupportedProtocols </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Enumerates the various communication transport protocols that the ZIS supports"</para>
	/// <para>To remove the <c>SIF_SupportedProtocols</c>, set <c>SIF_SupportedProtocols</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_SupportedProtocols SIF_SupportedProtocols
	{
		get
		{
			return (SIF_SupportedProtocols)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDPROTOCOLS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDPROTOCOLS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDPROTOCOLS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_DeletePublishers&gt;</c> element.
	/// </summary>
	/// <value> A SIF_DeletePublishers </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_DeletePublishers</c>, set <c>SIF_DeletePublishers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_DeletePublishers SIF_DeletePublishers
	{
		get
		{
			return (SIF_DeletePublishers)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_DELETEPUBLISHERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_DELETEPUBLISHERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_DELETEPUBLISHERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SupportedVersions&gt;</c> element.
	/// </summary>
	/// <value> A SIF_SupportedVersions </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Enumerates the versions of the SIF Specification that the ZIS can use when communicating with the SIF_SIFNode"</para>
	/// <para>To remove the <c>SIF_SupportedVersions</c>, set <c>SIF_SupportedVersions</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_SupportedVersions SIF_SupportedVersions
	{
		get
		{
			return (SIF_SupportedVersions)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDVERSIONS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDVERSIONS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_SUPPORTEDVERSIONS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_AdministrationURL&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_AdministrationURL</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Should a ZIS vendor provide an administration interface for the zone via a URL, the ZIS can make the URL available in SIF_ZoneStatus. Agent administrators can use the URL to access zone administration features, should they have permission to do so."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string SIF_AdministrationURL
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ZONESTATUS_SIF_ADMINISTRATIONURL ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ZONESTATUS_SIF_ADMINISTRATIONURL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Responders&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Responders </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Responders</c>, set <c>SIF_Responders</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Responders SIF_Responders
	{
		get
		{
			return (SIF_Responders)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_RESPONDERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_RESPONDERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_RESPONDERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Requesters&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Requesters </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Requesters</c>, set <c>SIF_Requesters</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Requesters SIF_Requesters
	{
		get
		{
			return (SIF_Requesters)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_REQUESTERS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_REQUESTERS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_REQUESTERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Contexts&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Contexts </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Contexts</c>, set <c>SIF_Contexts</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Contexts SIF_Contexts
	{
		get
		{
			return (SIF_Contexts)GetChild( InfraDTD.SIF_ZONESTATUS_SIF_CONTEXTS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ZONESTATUS_SIF_CONTEXTS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ZONESTATUS_SIF_CONTEXTS, value );
			}
		}
	}

}}
