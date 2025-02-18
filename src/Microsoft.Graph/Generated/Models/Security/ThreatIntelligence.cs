// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class ThreatIntelligence : Entity, IParsable {
        /// <summary>Refers to indicators of threat or compromise highlighted in an article.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ArticleIndicator>? ArticleIndicators {
            get { return BackingStore?.Get<List<ArticleIndicator>?>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#nullable restore
#else
        public List<ArticleIndicator> ArticleIndicators {
            get { return BackingStore?.Get<List<ArticleIndicator>>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#endif
        /// <summary>A list of article objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Article>? Articles {
            get { return BackingStore?.Get<List<Article>?>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#nullable restore
#else
        public List<Article> Articles {
            get { return BackingStore?.Get<List<Article>>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#endif
        /// <summary>Retrieve details about hostComponent objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostComponent>? HostComponents {
            get { return BackingStore?.Get<List<HostComponent>?>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#nullable restore
#else
        public List<HostComponent> HostComponents {
            get { return BackingStore?.Get<List<HostComponent>>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#endif
        /// <summary>Retrieve details about hostCookie objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostCookie>? HostCookies {
            get { return BackingStore?.Get<List<HostCookie>?>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#nullable restore
#else
        public List<HostCookie> HostCookies {
            get { return BackingStore?.Get<List<HostCookie>>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostPair>? HostPairs {
            get { return BackingStore?.Get<List<HostPair>?>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#nullable restore
#else
        public List<HostPair> HostPairs {
            get { return BackingStore?.Get<List<HostPair>>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#endif
        /// <summary>Refers to host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Host>? Hosts {
            get { return BackingStore?.Get<List<Host>?>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#nullable restore
#else
        public List<Host> Hosts {
            get { return BackingStore?.Get<List<Host>>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#endif
        /// <summary>Retrieve details about hostSslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostSslCertificate>? HostSslCertificates {
            get { return BackingStore?.Get<List<HostSslCertificate>?>("hostSslCertificates"); }
            set { BackingStore?.Set("hostSslCertificates", value); }
        }
#nullable restore
#else
        public List<HostSslCertificate> HostSslCertificates {
            get { return BackingStore?.Get<List<HostSslCertificate>>("hostSslCertificates"); }
            set { BackingStore?.Set("hostSslCertificates", value); }
        }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostTracker>? HostTrackers {
            get { return BackingStore?.Get<List<HostTracker>?>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#nullable restore
#else
        public List<HostTracker> HostTrackers {
            get { return BackingStore?.Get<List<HostTracker>>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#endif
        /// <summary>The intelligenceProfileIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntelligenceProfileIndicator>? IntelligenceProfileIndicators {
            get { return BackingStore?.Get<List<IntelligenceProfileIndicator>?>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#nullable restore
#else
        public List<IntelligenceProfileIndicator> IntelligenceProfileIndicators {
            get { return BackingStore?.Get<List<IntelligenceProfileIndicator>>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#endif
        /// <summary>A list of intelligenceProfile objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntelligenceProfile>? IntelProfiles {
            get { return BackingStore?.Get<List<IntelligenceProfile>?>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#nullable restore
#else
        public List<IntelligenceProfile> IntelProfiles {
            get { return BackingStore?.Get<List<IntelligenceProfile>>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#endif
        /// <summary>Retrieve details about passiveDnsRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PassiveDnsRecord>? PassiveDnsRecords {
            get { return BackingStore?.Get<List<PassiveDnsRecord>?>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#nullable restore
#else
        public List<PassiveDnsRecord> PassiveDnsRecords {
            get { return BackingStore?.Get<List<PassiveDnsRecord>>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#endif
        /// <summary>Retrieve details about sslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SslCertificate>? SslCertificates {
            get { return BackingStore?.Get<List<SslCertificate>?>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#nullable restore
#else
        public List<SslCertificate> SslCertificates {
            get { return BackingStore?.Get<List<SslCertificate>>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#endif
        /// <summary>Retrieve details about the subdomain.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subdomain>? Subdomains {
            get { return BackingStore?.Get<List<Subdomain>?>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#nullable restore
#else
        public List<Subdomain> Subdomains {
            get { return BackingStore?.Get<List<Subdomain>>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#endif
        /// <summary>Retrieve details about vulnerabilities.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Vulnerability>? Vulnerabilities {
            get { return BackingStore?.Get<List<Vulnerability>?>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#nullable restore
#else
        public List<Vulnerability> Vulnerabilities {
            get { return BackingStore?.Get<List<Vulnerability>>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#endif
        /// <summary>Retrieve details about whoisHistoryRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisHistoryRecord>? WhoisHistoryRecords {
            get { return BackingStore?.Get<List<WhoisHistoryRecord>?>("whoisHistoryRecords"); }
            set { BackingStore?.Set("whoisHistoryRecords", value); }
        }
#nullable restore
#else
        public List<WhoisHistoryRecord> WhoisHistoryRecords {
            get { return BackingStore?.Get<List<WhoisHistoryRecord>>("whoisHistoryRecords"); }
            set { BackingStore?.Set("whoisHistoryRecords", value); }
        }
#endif
        /// <summary>A list of whoisRecord objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisRecord>? WhoisRecords {
            get { return BackingStore?.Get<List<WhoisRecord>?>("whoisRecords"); }
            set { BackingStore?.Set("whoisRecords", value); }
        }
#nullable restore
#else
        public List<WhoisRecord> WhoisRecords {
            get { return BackingStore?.Get<List<WhoisRecord>>("whoisRecords"); }
            set { BackingStore?.Set("whoisRecords", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ThreatIntelligence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThreatIntelligence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"articleIndicators", n => { ArticleIndicators = n.GetCollectionOfObjectValues<ArticleIndicator>(ArticleIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                {"articles", n => { Articles = n.GetCollectionOfObjectValues<Article>(Article.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostComponents", n => { HostComponents = n.GetCollectionOfObjectValues<HostComponent>(HostComponent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostCookies", n => { HostCookies = n.GetCollectionOfObjectValues<HostCookie>(HostCookie.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostPairs", n => { HostPairs = n.GetCollectionOfObjectValues<HostPair>(HostPair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostSslCertificates", n => { HostSslCertificates = n.GetCollectionOfObjectValues<HostSslCertificate>(HostSslCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostTrackers", n => { HostTrackers = n.GetCollectionOfObjectValues<HostTracker>(HostTracker.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hosts", n => { Hosts = n.GetCollectionOfObjectValues<Host>(Host.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intelProfiles", n => { IntelProfiles = n.GetCollectionOfObjectValues<IntelligenceProfile>(IntelligenceProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intelligenceProfileIndicators", n => { IntelligenceProfileIndicators = n.GetCollectionOfObjectValues<IntelligenceProfileIndicator>(IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passiveDnsRecords", n => { PassiveDnsRecords = n.GetCollectionOfObjectValues<PassiveDnsRecord>(PassiveDnsRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sslCertificates", n => { SslCertificates = n.GetCollectionOfObjectValues<SslCertificate>(SslCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subdomains", n => { Subdomains = n.GetCollectionOfObjectValues<Subdomain>(Subdomain.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<Vulnerability>(Vulnerability.CreateFromDiscriminatorValue)?.ToList(); } },
                {"whoisHistoryRecords", n => { WhoisHistoryRecords = n.GetCollectionOfObjectValues<WhoisHistoryRecord>(WhoisHistoryRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"whoisRecords", n => { WhoisRecords = n.GetCollectionOfObjectValues<WhoisRecord>(WhoisRecord.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ArticleIndicator>("articleIndicators", ArticleIndicators);
            writer.WriteCollectionOfObjectValues<Article>("articles", Articles);
            writer.WriteCollectionOfObjectValues<HostComponent>("hostComponents", HostComponents);
            writer.WriteCollectionOfObjectValues<HostCookie>("hostCookies", HostCookies);
            writer.WriteCollectionOfObjectValues<HostPair>("hostPairs", HostPairs);
            writer.WriteCollectionOfObjectValues<Host>("hosts", Hosts);
            writer.WriteCollectionOfObjectValues<HostSslCertificate>("hostSslCertificates", HostSslCertificates);
            writer.WriteCollectionOfObjectValues<HostTracker>("hostTrackers", HostTrackers);
            writer.WriteCollectionOfObjectValues<IntelligenceProfileIndicator>("intelligenceProfileIndicators", IntelligenceProfileIndicators);
            writer.WriteCollectionOfObjectValues<IntelligenceProfile>("intelProfiles", IntelProfiles);
            writer.WriteCollectionOfObjectValues<PassiveDnsRecord>("passiveDnsRecords", PassiveDnsRecords);
            writer.WriteCollectionOfObjectValues<SslCertificate>("sslCertificates", SslCertificates);
            writer.WriteCollectionOfObjectValues<Subdomain>("subdomains", Subdomains);
            writer.WriteCollectionOfObjectValues<Vulnerability>("vulnerabilities", Vulnerabilities);
            writer.WriteCollectionOfObjectValues<WhoisHistoryRecord>("whoisHistoryRecords", WhoisHistoryRecords);
            writer.WriteCollectionOfObjectValues<WhoisRecord>("whoisRecords", WhoisRecords);
        }
    }
}
