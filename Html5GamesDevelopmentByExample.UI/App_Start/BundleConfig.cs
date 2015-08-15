using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Html5GamesDevelopmentByExample.UI.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new LessBundle("~/bundles/less").Include(
            //    "~/Content/*.less"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/chaptertwo/css").Include(
                "~/Content/ChapterTwo/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chaptertwo/js").Include(
                "~/Content/ChapterTwo/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterthree/css").Include(
                "~/Content/ChapterThree/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterthree/js").Include(
                "~/Content/ChapterThree/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterfour/css").Include(
                "~/Content/chapterfour/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterfour/js").Include(
                "~/Content/chapterfour/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterfive/css").Include(
                "~/Content/chapterfive/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterfive/js").Include(
                "~/Content/chapterfive/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chaptersix/css").Include(
                "~/Content/chaptersix/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chaptersix/js").Include(
                "~/Content/chaptersix/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterseven/css").Include(
                "~/Content/chapterseven/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterseven/js").Include(
                "~/Content/chapterseven/js/*.js"));

            //bundles.Add(new StyleBundle("~/bundles/chaptereight/css").Include(
            //    "~/Content/chaptereight/css/*.css"));
            //bundles.Add(new ScriptBundle("~/bundles/chaptereight/js").Include(
            //    "~/Content/chaptereight/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapternine/css").Include(
                "~/Content/chapternine/css/cargame.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapternine/protoclass").Include(
                "~/Content/chapternine/js/protoclass.js"));
            bundles.Add(new ScriptBundle("~/bundles/chapternine/box2d").Include(
                "~/Content/chapternine/js/box2d/common/b2Settings.js",
                "~/Content/chapternine/js/box2d/common/math/b2Vec2.js",
                "~/Content/chapternine/js/box2d/common/math/b2Mat22.js",
                "~/Content/chapternine/js/box2d/common/math/b2Math.js",
                "~/Content/chapternine/js/box2d/collision/b2AABB.js",
                "~/Content/chapternine/js/box2d/collision/b2Bound.js",
                "~/Content/chapternine/js/box2d/collision/b2BoundValues.js",
                "~/Content/chapternine/js/box2d/collision/b2Pair.js",
                "~/Content/chapternine/js/box2d/collision/b2PairCallback.js",
                "~/Content/chapternine/js/box2d/collision/b2BufferedPair.js",
                "~/Content/chapternine/js/box2d/collision/b2PairManager.js",
                "~/Content/chapternine/js/box2d/collision/b2BroadPhase.js",
                "~/Content/chapternine/js/box2d/collision/b2Collision.js",
                "~/Content/chapternine/js/box2d/collision/Features.js",
                "~/Content/chapternine/js/box2d/collision/b2ContactID.js",
                "~/Content/chapternine/js/box2d/collision/b2ContactPoint.js",
                "~/Content/chapternine/js/box2d/collision/b2Distance.js",
                "~/Content/chapternine/js/box2d/collision/b2Manifold.js",
                "~/Content/chapternine/js/box2d/collision/b2OBB.js",
                "~/Content/chapternine/js/box2d/collision/b2Proxy.js",
                "~/Content/chapternine/js/box2d/collision/ClipVertex.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2Shape.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2ShapeDef.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2BoxDef.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2CircleDef.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2CircleShape.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2MassData.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2PolyDef.js",
                "~/Content/chapternine/js/box2d/collision/shapes/b2PolyShape.js",
                "~/Content/chapternine/js/box2d/dynamics/b2Body.js",
                "~/Content/chapternine/js/box2d/dynamics/b2BodyDef.js",
                "~/Content/chapternine/js/box2d/dynamics/b2CollisionFilter.js",
                "~/Content/chapternine/js/box2d/dynamics/b2Island.js",
                "~/Content/chapternine/js/box2d/dynamics/b2TimeStep.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2ContactNode.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2Contact.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2ContactConstraint.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2ContactConstraintPoint.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2ContactRegister.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2ContactSolver.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2CircleContact.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2Conservative.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2NullContact.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2PolyAndCircleContact.js",
                "~/Content/chapternine/js/box2d/dynamics/contacts/b2PolyContact.js",
                "~/Content/chapternine/js/box2d/dynamics/b2ContactManager.js",
                "~/Content/chapternine/js/box2d/dynamics/b2World.js",
                "~/Content/chapternine/js/box2d/dynamics/b2WorldListener.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2JointNode.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2Joint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2JointDef.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2DistanceJoint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2DistanceJointDef.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2Jacobian.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2GearJoint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2GearJointDef.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2MouseJoint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2MouseJointDef.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2PrismaticJoint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2PrismaticJointDef.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2PulleyJoint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2PulleyJointDef.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2RevoluteJoint.js",
                "~/Content/chapternine/js/box2d/dynamics/joints/b2RevoluteJointDef.js"));
            bundles.Add(new ScriptBundle("~/bundles/chapternine/js").Include(
                "~/Content/chapternine/js/html5games.box2dcargame.js"));

            bundles.Add(new StyleBundle("~/bundles/canvasengine/css").Include(
                "~/Content/canvasengine/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/canvasengine/js").Include(
                "~/Content/canvasengine/js/canvasengine-1.3.2.all.min.js",
                "~/Content/canvasengine/js/main.js"));
        }
    }
}