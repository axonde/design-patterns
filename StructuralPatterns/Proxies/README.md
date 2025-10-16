## Proxy, proxy, `proxy`!

A way to envelop a class (often closed or logically hard to develop by himself) with a possibility to add additional control and over top event listening.

If you learn `Decorator` pattern you may be a little confusing: both of them are so similar!
And you are partially right. However, there is a big difference: a decorator is specially controlled by the user (he manually set decorators wrapper), when proxy is a hidden control construction by default. User, when use the proxy, don't need to know, that he use it)

Example:

- [Role Checker](RoleChecker/README.md)
