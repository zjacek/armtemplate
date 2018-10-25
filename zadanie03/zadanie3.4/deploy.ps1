
New-AzureRmResourceGroupDeployment -Name NewVM -ResourceGroupName TestVM -TemplateFile createVM.json -TemplateParameterFile createVM.parameters.json
