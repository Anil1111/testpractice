﻿using NUnit.Framework;

namespace TestPractice.Fundamentals.UnitTests {
    // TestClass and TestMethod attributes belongs to MSTestFramework.
    [TestFixture]
    public class ReservationTests {
        [Test]
        // 1) Specifies the name of the method on the test_
        // 2) Scenario of the testing_
        // 3) Expected behavior
        // -> Thus, these tests act as the documentation about the source code.
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() {
            /* Tripple A convention */
            // 1. Arrange: Initialize the objects
            var reservation = new Reservation();

            // 2. Act: Act on this object; call a method which is going to be tested
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // 3. Assert: Verify the result is correct
            Assert.That(result, Is.True);   // This reads like plain English (which is better)
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue() {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse() {
            var user = new User() { IsAdmin = false };
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.False);
        }
    }
}