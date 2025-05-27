# GHLearning-EasyNLog
[![.NET](https://github.com/gordon-hung/GHLearning-EasyNLog/actions/workflows/dotnet.yml/badge.svg)](https://github.com/gordon-hung/GHLearning-EasyNLog/actions/workflows/dotnet.yml) [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/gordon-hung/GHLearning-EasyNLog)

## Purpose and Scope
The GHLearning-EasyNLog repository is an educational codebase designed to demonstrate NLog integration patterns with multiple logging targets in ASP.NET Core applications. This repository contains five demonstration applications, each showcasing how to integrate NLog with different external logging systems including console/file output, Elasticsearch, Loki, Seq, and Sentry.

This overview covers the repository structure, common architectural patterns, and learning progression. For detailed information about setting up the development environment and CI/CD pipeline, see Getting Started. For implementation details of specific demo applications, see Demo Applications.

## Repository Structure
The repository follows a clean solution structure with all demonstration projects organized under a src folder. Each project represents a complete ASP.NET Core Web API application with NLog integration targeting a specific logging destination.

## Key Features
### Standardized API Endpoints
- LoggersController with endpoints for Error, Info, Warning, Debug, and Trace logging
- InfoController for retrieving system information
- Health check endpoints at /live and /healthz

### Comprehensive Documentation
- Swagger UI for interactive API testing
- ReDoc for detailed API documentation
- Scalar API reference for modern documentation experience
- HTTP test files for rapid endpoint testing

### Development Best Practices
- EditorConfig for consistent code formatting
- CI/CD pipeline with GitHub Actions
- Health monitoring for production readiness
- Environment-specific configuration management

This repository serves as a practical reference for implementing NLog in real-world scenarios, demonstrating both basic - concepts and advanced integration patterns with popular logging platforms.

## source
- [NLog](https://github.com/NLog/NLog)
- [NLog.Extensions.Logging](https://github.com/NLog/NLog.Extensions.Logging)
- [NLog.Web](https://github.com/NLog/NLog.Web)
- [NLog.Targets.ElasticSearch](https://github.com/markmcdowell/NLog.Targets.ElasticSearch)
- [NLog.Targets.Loki](https://github.com/corentinaltepe/nlog.loki)
- [NLog.Targets.Sentry3](https://github.com/CurtisInstruments/NLog.Targets.Sentry)
- [NLog.Targets.Seq](https://github.com/datalust/nlog-targets-seq)