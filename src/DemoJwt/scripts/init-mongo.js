db.createUser(
    {
        user: "basicuser",
        pwd: "basicpassword",
        roles: [
            {
                role: 'readWrite',
                db: 'application-dotnet'
            }
        ]
    }
)