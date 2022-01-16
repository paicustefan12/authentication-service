FROM mcr.microsoft.com/dotnet/aspnet:5.0
# Create app directory
WORKDIR /app
# Copy only the deployment artifacts
COPY /out .
ENTRYPOINT ["dotnet", "AuthenticationService.dll"]