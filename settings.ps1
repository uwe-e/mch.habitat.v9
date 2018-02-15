# Solution parameters
$SolutionPrefix = "mch.habitat.v9"
$SitePostFix = "dev.local"
$webroot = "C:\Work\Sitecore"

$SitecoreVersion = "9.0.1 rev. 171219"
$InstallerVersion = "1.0.2"

# Assets and prerequisites
$AssetsRoot = "$PSScriptRoot\build\assets"
$AssetsConfigRoot = "$PSScriptRoot\build\AssetsConfiguration"
$AssetsPSRepository = "https://sitecore.myget.org/F/sc-powershell/api/v2/"
$AssetsPSRepositoryName = "SitecoreGallery"

$LicenseFile = "$AssetsRoot\license.xml"

# Certificates
$CertPath = Join-Path "$AssetsRoot" "Certificates"

# SQL Parameters
$SqlServer = ".\SQLEXPRESS"
$SqlAdminUser = "sa"
$SqlAdminPassword = "test12345"

# XConnect Parameters
$XConnectConfiguration = "$AssetsConfigRoot\xconnect-xp0.json"
$XConnectCertificateConfiguration = "$AssetsConfigRoot\xconnect-createcert.json"
$XConnectSolrConfiguration = "$AssetsConfigRoot\xconnect-solr.json"
$XConnectPackage = "$AssetsRoot\Sitecore $SitecoreVersion (OnPrem)_xp0xconnect.scwdp.zip"
$XConnectSiteName = "${SolutionPrefix}_xconnect.$SitePostFix"
$XConnectCert = "$SolutionPrefix.$SitePostFix.xConnect.Client"
$XConnectSiteRoot = Join-Path $webroot -ChildPath $XConnectSiteName
$XConnectSqlCollectionUser = "collectionuser"
$XConnectSqlCollectionPassword = "test12345"

# Sitecore Parameters
$SitecoreSolrConfiguration = "$AssetsConfigRoot\sitecore-solr.json"
$SitecoreConfiguration = "$AssetsConfigRoot\sitecore-xp0.json"
$SitecoreSSLConfiguration = "$PSScriptRoot\build\certificates\sitecore-ssl.json"
$SitecorePackage = "$AssetsRoot\Sitecore $SitecoreVersion (OnPrem)_single.scwdp.zip"
$SitecoreSiteName = "$SolutionPrefix.$SitePostFix"
#$SitecoreSiteRoot = Join-Path $webroot -ChildPath $SitecoreSiteName
$SitecoreSiteRoot = $webroot


# Solr Parameters
$SolrUrl = "https://localhost:8983/solr"
$SolrRoot = "C:\\solr\\solr-6.6.2"
$SolrService = "solr-6.6.2"
