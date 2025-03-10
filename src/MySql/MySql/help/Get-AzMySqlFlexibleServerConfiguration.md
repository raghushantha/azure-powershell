---
external help file: Az.MySql-help.xml
Module Name: Az.MySql
online version: https://learn.microsoft.com/powershell/module/az.mysql/get-azmysqlflexibleserverconfiguration
schema: 2.0.0
---

# Get-AzMySqlFlexibleServerConfiguration

## SYNOPSIS
Gets information about a configuration of server.

## SYNTAX

### List (Default)
```
Get-AzMySqlFlexibleServerConfiguration -ResourceGroupName <String> -ServerName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

### Get
```
Get-AzMySqlFlexibleServerConfiguration -Name <String> -ResourceGroupName <String> -ServerName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzMySqlFlexibleServerConfiguration -InputObject <IMySqlIdentity> [-DefaultProfile <PSObject>]
 [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
Gets information about a configuration of server.

## EXAMPLES

### Example 1: List all configurations in specified MySql server
```powershell
Get-AzMySqlFlexibleServerConfiguration -ResourceGroupName PowershellMySqlTest -ServerName mysql-test
```

```output
Name                                     Value
----                                     -----
archive                                  OFF
audit_log_enabled                        OFF
audit_log_events                         CONNECTION
audit_log_exclude_users                  azure_superuser
...
wait_timeout                             28800
```

This cmdlet lists all configurations in specified MySql server.

### Example 2: Get specified MySql configuration by name
```powershell
Get-AzMySqlFlexibleServerConfiguration -Name wait_timeout -ResourceGroupName PowershellMySqlTest -ServerName mysql-test
```

```output
Name         Value AllowedValue Source         DefaultValue
----         ----- ------------ ------         ------------
wait_timeout 28800 1-31536000   system-default 28800
```

This cmdlet gets specified MySql configuration by name.

### Example 3: List configuration by identity
```powershell
$ID = "/subscriptions/<SubscriptionId>/resourceGroups/PowershellMySqlTest/providers/Microsoft.DBforMySQL/flexibleServers/mysql-test/configurations/wait_timeout"
Get-AzMySqlFlexibleServerConfiguration -Name wait_timeout -ResourceGroupName PowershellMySqlTest -ServerName mysql-test
```

```output
Name         Value AllowedValue Source         DefaultValue
----         ----- ------------ ------         ------------
wait_timeout 28800 1-31536000   system-default 28800
```

This cmdlet gets specified MySql configuration by identity.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the server configuration.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: ConfigurationName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: System.Management.Automation.ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerName
The name of the server.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: List, Get
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated

## NOTES

## RELATED LINKS
