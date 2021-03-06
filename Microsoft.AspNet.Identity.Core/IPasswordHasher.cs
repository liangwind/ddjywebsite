﻿// Copyright (c) Microsoft Corporation, Inc. All rights reserved.
// Licensed under the MIT License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Identity
{
    /// <summary>
    ///     Abstraction for password hashing methods
    /// </summary>
    public interface IPasswordHasher
    {
        /// <summary>
        ///     Hash a password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string HashPassword(string password,string salt);

        /// <summary>
        ///     Verify that a password matches the hashed password
        /// </summary>
        /// <param name="hashedPassword"></param>
        /// <param name="providedPassword"></param>
        /// <returns></returns>
        PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword,string salt);
    }
}