// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FirewallPolicyRuleGroupsOperations.
    /// </summary>
    public static partial class FirewallPolicyRuleGroupsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            public static void Delete(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName)
            {
                operations.DeleteAsync(resourceGroupName, firewallPolicyName, ruleGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            public static FirewallPolicyRuleGroup Get(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName)
            {
                return operations.GetAsync(resourceGroupName, firewallPolicyName, ruleGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallPolicyRuleGroup> GetAsync(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update FirewallPolicyRuleGroup
            /// operation.
            /// </param>
            public static FirewallPolicyRuleGroup CreateOrUpdate(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update FirewallPolicyRuleGroup
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallPolicyRuleGroup> CreateOrUpdateAsync(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            public static IPage<FirewallPolicyRuleGroup> List(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName)
            {
                return operations.ListAsync(resourceGroupName, firewallPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallPolicyRuleGroup>> ListAsync(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            public static void BeginDelete(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, firewallPolicyName, ruleGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update FirewallPolicyRuleGroup
            /// operation.
            /// </param>
            public static FirewallPolicyRuleGroup BeginCreateOrUpdate(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleGroupName'>
            /// The name of the FirewallPolicyRuleGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update FirewallPolicyRuleGroup
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallPolicyRuleGroup> BeginCreateOrUpdateAsync(this IFirewallPolicyRuleGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FirewallPolicyRuleGroup> ListNext(this IFirewallPolicyRuleGroupsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallPolicyRuleGroup>> ListNextAsync(this IFirewallPolicyRuleGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}