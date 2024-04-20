---
title: Alteration
---
## ININ.PureCloudApi.Model.Alteration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Type** | **string** | Range type (Exclusion: used to exclude a specific time within the recurrence. Inclusion: used to include a specific time within the recurrence which will execute in addition to the normal recurrence. If both an exclusion and inclusion are specified, the inclusion will take precedence over the exclusion.) | [optional] |
| **Start** | **string** | The start date of an alteration range as an ISO-8601 string in UTC time, e.g: 2023-12-21T16:30:25.000Z | [optional] |
| **End** | **string** | The end date of an alteration range as an ISO-8601 string in UTC time, e.g: 2023-12-21T18:30:25.000Z | [optional] |
{: class="table table-striped"}

