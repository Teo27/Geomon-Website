<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="AzureCloudService" generation="1" functional="0" release="0" Id="a2332a67-197a-4096-8549-80edf0cddb9b" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="AzureCloudServiceGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="WCFServiceWebRole1:InputHttp8080" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/AzureCloudService/AzureCloudServiceGroup/LB:WCFServiceWebRole1:InputHttp8080" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="WCFServiceWebRole1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/AzureCloudService/AzureCloudServiceGroup/MapWCFServiceWebRole1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WCFServiceWebRole1Instances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/AzureCloudService/AzureCloudServiceGroup/MapWCFServiceWebRole1Instances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:WCFServiceWebRole1:InputHttp8080">
          <toPorts>
            <inPortMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1/InputHttp8080" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWCFServiceWebRole1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWCFServiceWebRole1Instances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1Instances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="WCFServiceWebRole1" generation="1" functional="0" release="0" software="C:\Users\dell\Documents\Visual Studio 2015\Projects\GeomonAzure\AzureCloudService\csx\Release\roles\WCFServiceWebRole1" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="InputHttp8080" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WCFServiceWebRole1&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;WCFServiceWebRole1&quot;&gt;&lt;e name=&quot;InputHttp8080&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1Instances" />
            <sCSPolicyUpdateDomainMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1UpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1FaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WCFServiceWebRole1UpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WCFServiceWebRole1FaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WCFServiceWebRole1Instances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="d3e9e91c-a41f-4e12-94b3-6e6ca5840d1c" ref="Microsoft.RedDog.Contract\ServiceContract\AzureCloudServiceContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="d04e8019-af48-4b87-afc3-a93fc5b60f93" ref="Microsoft.RedDog.Contract\Interface\WCFServiceWebRole1:InputHttp8080@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/AzureCloudService/AzureCloudServiceGroup/WCFServiceWebRole1:InputHttp8080" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>