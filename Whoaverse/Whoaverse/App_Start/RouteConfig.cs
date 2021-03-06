﻿/*
This source file is subject to version 3 of the GPL license, 
that is bundled with this package in the file LICENSE, and is 
available online at http://www.gnu.org/licenses/gpl.txt; 
you may not use this file except in compliance with the License. 

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
the specific language governing rights and limitations under the License.

All portions of the code written by Whoaverse are Copyright (c) 2014 Whoaverse
All Rights Reserved.
*/

using System.Web.Mvc;
using System.Web.Routing;

namespace Whoaverse
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;

            // /rss
            routes.MapRoute(
                name: "rss",
                url: "rss/{subverseName}",
                defaults: new { controller = "RSS", action = "RSS", subverseName = UrlParameter.Optional }                
            ); 

            // /subverses/create
            routes.MapRoute(
                name: "CreateSubverse",
                url: "subverses/create",
                defaults: new { controller = "Subverses", action = "CreateSubverse" }
            );

            // search
            routes.MapRoute(
                name: "Search",
                url: "search",
                defaults: new { controller = "Search", action = "SearchResults" }
            );                        

            // /subverses
            routes.MapRoute(
                name: "Subverses",
                url: "subverses/",
                defaults: new { controller = "Subverses", action = "Subverses" }
            );

            // /subverses/search
            routes.MapRoute(
                name: "SubversesSearch",
                url: "subverses/search",
                defaults: new { controller = "Subverses", action = "Search" }
            );

            // /subverses/subscribed
            routes.MapRoute(
                name: "SubscribedSubverses",
                url: "subverses/subscribed",
                defaults: new { controller = "Subverses", action = "SubversesSubscribed" }
            );

            // /subverses/adultcontent
            routes.MapRoute(
                name: "AdultContentWarning",
                url: "subverses/adultcontent",
                defaults: new { controller = "Subverses", action = "AdultContentWarning" }
            );

            // /subverses/adultcontent
            routes.MapRoute(
                name: "AdultContentFiltered",
                url: "subverses/adultcontentfiltered",
                defaults: new { controller = "Subverses", action = "AdultContentFiltered" }
            );

            // /subverses/new
            routes.MapRoute(
                name: "SubversesNew",
                url: "subverses/{sortingmode}",
                defaults: new { controller = "Subverses", action = "NewestSubverses" }
            );            

            // comments/4
            routes.MapRoute(
                name: "comments",
                url: "comments/{id}",
                defaults: new { controller = "Comment", action = "Comments" }
            );

            // user/someuserhere/thingtoshow
            routes.MapRoute(
                name: "userprofilefilter",
                url: "user/{id}/{whattodisplay}",
                defaults: new { controller = "Home", action = "UserProfile", whattodisplay = UrlParameter.Optional }
            );

            // user/someuserhere
            routes.MapRoute(
                name: "user",
                url: "user/{id}",
                defaults: new { controller = "Home", action = "UserProfile" }
            );

            // u/someuserhere
            routes.MapRoute(
                name: "usershortroute",
                url: "u/{id}",
                defaults: new { controller = "Home", action = "UserProfile" }
            );

            // inbox
            routes.MapRoute(
                name: "Inbox",
                url: "messaging/inbox",
                defaults: new { controller = "Messaging", action = "Inbox" }
            );

            // compose
            routes.MapRoute(
                name: "Compose",
                url: "messaging/compose",
                defaults: new { controller = "Messaging", action = "Compose" }
            );

            // send private message
            routes.MapRoute(
                name: "SendPrivateMessage",
                url: "messaging/sendprivatemessage",
                defaults: new { controller = "Messaging", action = "SendPrivateMessage" }
            );

            // compose
            routes.MapRoute(
                name: "Sent",
                url: "messaging/sent",
                defaults: new { controller = "Messaging", action = "Sent" }
            );

            // commentreplies
            routes.MapRoute(
                name: "CommentReplies",
                url: "messaging/commentreplies",
                defaults: new { controller = "Messaging", action = "InboxCommentReplies" }
            );

            // postreplies
            routes.MapRoute(
                name: "PostReplies",
                url: "messaging/postreplies",
                defaults: new { controller = "Messaging", action = "InboxPostReplies" }
            );

            // deleteprivatemessage
            routes.MapRoute(
                name: "DeletePrivateMessage",
                url: "messaging/delete",
                defaults: new { controller = "Messaging", action = "DeletePrivateMessage" }
            );

            // deleteprivatemessagefromsent
            routes.MapRoute(
                name: "DeletePrivateMessageFromSent",
                url: "messaging/deletesent",
                defaults: new { controller = "Messaging", action = "DeletePrivateMessageFromSent" }
            );            

            // help/pagetoshow
            routes.MapRoute(
                name: "Help",
                url: "help/{*pagetoshow}",
                defaults: new { controller = "Home", action = "Help" }
            );

            // about/pagetoshow
            routes.MapRoute(
                name: "About",
                url: "about/{*pagetoshow}",
                defaults: new { controller = "Home", action = "About" }
            );

            // cla
            routes.MapRoute(
                name: "cla",
                url: "cla/",
                defaults: new { controller = "Home", action = "Cla" }
            );

            // subscribe
            routes.MapRoute(
                name: "subscribe",
                url: "subscribe/{subverseName}",
                defaults: new { controller = "Subverses", action = "Subscribe" }
            );

            // unsubscribe
            routes.MapRoute(
                name: "unsubscribe",
                url: "unsubscribe/{subverseName}",
                defaults: new { controller = "Subverses", action = "UnSubscribe" }
            );

            // vote
            routes.MapRoute(
                name: "vote",
                url: "vote/{messageId}/{typeOfVote}",
                defaults: new { controller = "Submissions", action = "Vote" }
            );

            // vote comment
            routes.MapRoute(
                name: "votecomment",
                url: "votecomment/{commentId}/{typeOfVote}",
                defaults: new { controller = "Comment", action = "VoteComment" }
            );

            // editcomment
            routes.MapRoute(
                  "editcomment",
                  "editcomment/{id}",
                  new { controller = "Comment", action = "EditComment", id = UrlParameter.Optional }
             );

            // deletecomment
            routes.MapRoute(
                  "deletecomment",
                  "deletecomment/{id}",
                  new { controller = "Comment", action = "DeleteComment", id = UrlParameter.Optional }
             );

            // reportcomment
            routes.MapRoute(
                  "reportcomment",
                  "reportcomment/{id}",
                  new { controller = "Report", action = "ReportComment", id = UrlParameter.Optional }
             );

            // editsubmission
            routes.MapRoute(
                  "editsubmission",
                  "editsubmission/{id}",
                  new { controller = "Submissions", action = "EditSubmission", id = UrlParameter.Optional }
             );

            // deletesubmission
            routes.MapRoute(
                  "deletesubmission",
                  "deletesubmission/{id}",
                  new { controller = "Submissions", action = "DeleteSubmission", id = UrlParameter.Optional }
             );

            // submit
            routes.MapRoute(
                name: "submit",
                url: "submit",
                defaults: new { controller = "Home", action = "Submit" }
            );

            // v/selectedsubverse/submit
            routes.MapRoute(
                name: "submitpost",
                url: "v/{selectedsubverse}/submit",
                defaults: new { controller = "Home", action = "Submit" }
            );

            // submitcomment
            routes.MapRoute(
                name: "submitcomment",
                url: "submitcomment",
                defaults: new { controller = "Comment", action = "SubmitComment" }
            );

            // /random
            routes.MapRoute(
                name: "randomSubverse",
                url: "random/",
                defaults: new { controller = "Subverses", action = "Random" }
            );

            // /new
            routes.MapRoute(
                name: "FrontpageLatestPosts",
                url: "{sortingmode}",
                defaults: new { controller = "Home", action = "New" }
            );

            // v/subversetoedit/about/edit
            routes.MapRoute(
                name: "subverseSettings",
                url: "v/{subversetoshow}/about/edit",
                defaults: new { controller = "Subverses", action = "SubverseSettings" }
            );

            // v/subversetoedit/about/flair
            routes.MapRoute(
                name: "subverseFlairSettings",
                url: "v/{subversetoshow}/about/flair",
                defaults: new { controller = "Subverses", action = "SubverseFlairSettings" }
            );

            // v/subversetoedit/about/linkflair/add
            routes.MapRoute(
                name: "addSubverseLinkFlair",
                url: "v/{subversetoshow}/about/linkflair/add",
                defaults: new { controller = "Subverses", action = "AddLinkFlair" }
            );

            // v/subversetoedit/about/linkflair/delete
            routes.MapRoute(
                name: "removeSubverseLinkFlair",
                url: "v/{subversetoshow}/about/flair/delete/{id}",
                defaults: new { controller = "Subverses", action = "RemoveLinkFlair" }
            );

            // v/subversetoedit/about/moderators
            routes.MapRoute(
                name: "subverseModerators",
                url: "v/{subversetoshow}/about/moderators",
                defaults: new { controller = "Subverses", action = "SubverseModerators" }
            );

            // v/subversetoedit/about/moderators/add
            routes.MapRoute(
                name: "addSubverseModerator",
                url: "v/{subversetoshow}/about/moderators/add",
                defaults: new { controller = "Subverses", action = "AddModerator" }
            );

            // v/subversetoedit/about/moderators/delete
            routes.MapRoute(
                name: "removeSubverseModerator",
                url: "v/{subversetoshow}/about/moderators/delete/{id}",
                defaults: new { controller = "Subverses", action = "RemoveModerator" }
            );

            // v/subversetoedit/about/moderators/leave
            routes.MapRoute(
                name: "resignAsModerator",
                url: "v/{subversetoresignfrom}/about/moderators/resign/",
                defaults: new { controller = "Subverses", action = "ResignAsModerator" }
            );

            // v/subversetoshow
            routes.MapRoute(
                name: "SubverseIndex",
                url: "v/{subversetoshow}",
                defaults: new { controller = "Subverses", action = "Index" }
            );

            // domains/domainname.com
            routes.MapRoute(
                name: "DomainIndex",
                url: "domains/{domainname}.{ext}",
                defaults: new { controller = "Domains", action = "Index" }
            );

            // domains/domainname.com/new
            routes.MapRoute(
                name: "DomainIndexSorted",
                url: "domains/{domainname}.{ext}/{sortingmode}",
                defaults: new { controller = "Domains", action = "New", sortingmode = UrlParameter.Optional }
            );

            // v/subversetoshow/comments/123456
            routes.MapRoute(
                name: "SubverseComments",
                url: "v/{subversetoshow}/comments/{id}/{startingcommentid}",
                defaults: new { controller = "Comment", action = "Comments", startingcommentid = UrlParameter.Optional }
            );            

            // v/subversetoshow/sortingmode
            routes.MapRoute(
                name: "SubverseLatestPosts",
                url: "v/{subversetoshow}/{sortingmode}",
                defaults: new { controller = "Subverses", action = "SortedSubverseFrontpage" }
            );

            // ajaxhelpers/commentreplyform
            routes.MapRoute(
                name: "CommentReplyForm",
                url: "ajaxhelpers/commentreplyform/{parentCommentId}/{messageId}",
                defaults: new { controller = "HtmlElements", action = "CommentReplyForm" }
            );

            // ajaxhelpers/singlesubmissioncomment
            routes.MapRoute(
                name: "SingleSubmissionComment",
                url: "ajaxhelpers/singlesubmissioncomment/{messageId}/{userName}",
                defaults: new { controller = "HtmlElements", action = "SingleMostRecentCommentByUser" }
            );

            // ajaxhelpers/privatemessagereplyform
            routes.MapRoute(
                name: "PrivateMessageReplyForm",
                url: "ajaxhelpers/privatemessagereplyform/{parentPrivateMessageId}",
                defaults: new { controller = "HtmlElements", action = "PrivateMessageReplyForm" }
            ); 

            // ajaxhelpers/messagecontent
            routes.MapRoute(
                name: "MessageContent",
                url: "ajaxhelpers/messagecontent/{messageId}",
                defaults: new { controller = "AjaxGateway", action = "MessageContent" }
            );

            // ajaxhelpers/rendersubmission
            routes.MapRoute(
                name: "RenderSubmission",
                url: "ajaxhelpers/rendersubmission",
                defaults: new { controller = "AjaxGateway", action = "RenderSubmission" }
            );

            // ajaxhelpers/linkflairselectdialog
            routes.MapRoute(
                name: "LinkFlairSelectDialog",
                url: "ajaxhelpers/linkflairselectdialog/{subversetoshow}/{messageId}",
                defaults: new { controller = "AjaxGateway", action = "SubverseLinkFlairs" }
            );

            // ajaxhelpers/titlefromuri
            routes.MapRoute(
                name: "TitleFromUri",
                url: "ajaxhelpers/titlefromuri",
                defaults: new { controller = "AjaxGateway", action = "TitleFromUri" }
            );

            // ajaxhelpers/autocompletesubversename
            routes.MapRoute(
                name: "AutocompleteSubverseName",
                url: "ajaxhelpers/autocompletesubversename",
                defaults: new { controller = "AjaxGateway", action = "AutocompleteSubverseName" }
            );

            // submissions/applylinkflair
            routes.MapRoute(
                name: "ApplyLinkFlair",
                url: "submissions/applylinkflair/{submissionId}/{flairId}",
                defaults: new { controller = "Submissions", action = "ApplyLinkFlair" }
            );

            // submissions/clearlinkflair
            routes.MapRoute(
                name: "ClearLinkFlair",
                url: "submissions/clearlinkflair/{submissionId}",
                defaults: new { controller = "Submissions", action = "ClearLinkFlair" }
            );

            // submissions/togglesticky
            routes.MapRoute(
                name: "ToggleSticky",
                url: "submissions/togglesticky/{submissionId}",
                defaults: new { controller = "Submissions", action = "ToggleSticky" }
            );            

            // p/partnerprogram
            routes.MapRoute(
                name: "PartnerProgramInformation",
                url: "p/partnerprogram",
                defaults: new { controller = "Partner", action = "PartnerProgramInformation" }
            );

            // p/partnerintent
            routes.MapRoute(
                name: "PartnerProgramIntent",
                url: "p/apply",
                defaults: new { controller = "Partner", action = "PartnerIntentRegistration" }
            );
            
            // default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

        }
    }
}
