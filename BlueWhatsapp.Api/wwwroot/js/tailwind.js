﻿/**
 * Minified by jsDelivr using Terser v5.37.0.
 * Original file: /npm/@tailwindcss/browser@4.0.14/dist/index.global.js
 *
 * Do NOT use SRI with dynamically generated files! More information: https://www.jsdelivr.com/using-sri-with-dynamic-files
 */
"use strict";
(() => {
    var e = 10;

    function t(t) {
        "\ufeff" === t[0] && (t = t.slice(1)), t = t.replaceAll("\r\n", "\n");
        let o, i = [], l = [], a = [], s = null, c = null, u = "", d = "";
        for (let f = 0; f < t.length; f++) {
            let h = t.charCodeAt(f);
            if (92 === h) u += t.slice(f, f + 2), f += 1; else if (47 === h && 42 === t.charCodeAt(f + 1)) {
                let e = f;
                for (let e = f + 2; e < t.length; e++) if (o = t.charCodeAt(e), 92 === o) e += 1; else if (42 === o && 47 === t.charCodeAt(e + 1)) {
                    f = e + 1;
                    break
                }
                let r = t.slice(e, f + 1);
                33 === r.charCodeAt(2) && l.push(x(r.slice(2, -2)))
            } else if (39 === h || 34 === h) {
                let r = f;
                for (let n = f + 1; n < t.length; n++) if (o = t.charCodeAt(n), 92 === o) n += 1; else {
                    if (o === h) {
                        f = n;
                        break
                    }
                    if (59 === o && t.charCodeAt(n + 1) === e) throw new Error(`Unterminated string: ${t.slice(r, n + 1) + String.fromCharCode(h)}`);
                    if (o === e) throw new Error(`Unterminated string: ${t.slice(r, n) + String.fromCharCode(h)}`)
                }
                u += t.slice(r, f + 1)
            } else {
                if ((32 === h || h === e || 9 === h) && (o = t.charCodeAt(f + 1)) && (32 === o || o === e || 9 === o)) continue;
                if (h === e) {
                    if (0 === u.length) continue;
                    o = u.charCodeAt(u.length - 1), 32 !== o && o !== e && 9 !== o && (u += " ")
                } else if (45 === h && 45 === t.charCodeAt(f + 1) && 0 === u.length) {
                    let e = "", r = f, l = -1;
                    for (let n = f + 2; n < t.length; n++) if (o = t.charCodeAt(n), 92 === o) n += 1; else if (47 === o && 42 === t.charCodeAt(n + 1)) {
                        for (let e = n + 2; e < t.length; e++) if (o = t.charCodeAt(e), 92 === o) e += 1; else if (42 === o && 47 === t.charCodeAt(e + 1)) {
                            n = e + 1;
                            break
                        }
                    } else if (-1 === l && 58 === o) l = u.length + n - r; else {
                        if (59 === o && 0 === e.length) {
                            u += t.slice(r, n), f = n;
                            break
                        }
                        if (40 === o) e += ")"; else if (91 === o) e += "]"; else if (123 === o) e += "}"; else {
                            if ((125 === o || t.length - 1 === n) && 0 === e.length) {
                                f = n - 1, u += t.slice(r, n);
                                break
                            }
                            (41 === o || 93 === o || 125 === o) && e.length > 0 && t[n] === e[e.length - 1] && (e = e.slice(0, -1))
                        }
                    }
                    let a = n(u, l);
                    if (!a) throw new Error("Invalid custom property, expected a value");
                    s ? s.nodes.push(a) : i.push(a), u = ""
                } else if (59 === h && 64 === u.charCodeAt(0)) c = r(u), s ? s.nodes.push(c) : i.push(c), u = "", c = null; else if (59 === h && ")" !== d[d.length - 1]) {
                    let e = n(u);
                    if (!e) throw 0 === u.length ? new Error("Unexpected semicolon") : new Error(`Invalid declaration: \`${u.trim()}\``);
                    s ? s.nodes.push(e) : i.push(e), u = ""
                } else if (123 === h && ")" !== d[d.length - 1]) d += "}", c = k(u.trim()), s && s.nodes.push(c), a.push(s), s = c, u = "", c = null; else if (125 === h && ")" !== d[d.length - 1]) {
                    if ("" === d) throw new Error("Missing opening {");
                    if (d = d.slice(0, -1), u.length > 0) if (64 === u.charCodeAt(0)) c = r(u), s ? s.nodes.push(c) : i.push(c), u = "", c = null; else {
                        let e = u.indexOf(":");
                        if (s) {
                            let t = n(u, e);
                            if (!t) throw new Error(`Invalid declaration: \`${u.trim()}\``);
                            s.nodes.push(t)
                        }
                    }
                    let e = a.pop() ?? null;
                    null === e && s && i.push(s), s = e, u = "", c = null
                } else if (40 === h) d += ")", u += "("; else if (41 === h) {
                    if (")" !== d[d.length - 1]) throw new Error("Missing opening (");
                    d = d.slice(0, -1), u += ")"
                } else {
                    if (0 === u.length && (32 === h || h === e || 9 === h)) continue;
                    u += String.fromCharCode(h)
                }
            }
        }
        if (64 === u.charCodeAt(0) && i.push(r(u)), d.length > 0 && s) {
            if ("rule" === s.kind) throw new Error(`Missing closing } at ${s.selector}`);
            if ("at-rule" === s.kind) throw new Error(`Missing closing } at ${s.name} ${s.params}`)
        }
        return l.length > 0 ? l.concat(i) : i
    }

    function r(e, t = []) {
        for (let r = 5; r < e.length; r++) {
            let n = e.charCodeAt(r);
            if (32 === n || 40 === n) {
                return w(e.slice(0, r).trim(), e.slice(r).trim(), t)
            }
        }
        return w(e.trim(), "", t)
    }

    function n(e, t = e.indexOf(":")) {
        if (-1 === t) return null;
        let r = e.indexOf("!important", t + 1);
        return y(e.slice(0, t).trim(), e.slice(t + 1, -1 === r ? e.length : r).trim(), -1 !== r)
    }

    function o(e) {
        if (0 === arguments.length) throw new TypeError("`CSS.escape` requires an argument.");
        let t, r = String(e), n = r.length, o = -1, i = "", l = r.charCodeAt(0);
        if (1 === n && 45 === l) return "\\" + r;
        for (; ++o < n;) t = r.charCodeAt(o), i += 0 !== t ? t >= 1 && t <= 31 || 127 === t || 0 === o && t >= 48 && t <= 57 || 1 === o && t >= 48 && t <= 57 && 45 === l ? "\\" + t.toString(16) + " " : t >= 128 || 45 === t || 95 === t || t >= 48 && t <= 57 || t >= 65 && t <= 90 || t >= 97 && t <= 122 ? r.charAt(o) : "\\" + r.charAt(o) : "�";
        return i
    }

    function i(e) {
        return e.replace(/\\([\dA-Fa-f]{1,6}[\t\n\f\r ]?|[\S\s])/g, (e => e.length > 2 ? String.fromCodePoint(Number.parseInt(e.slice(1).trim(), 16)) : e[1]))
    }

    var l = new Map([["--font", ["--font-weight", "--font-size"]], ["--inset", ["--inset-shadow", "--inset-ring"]], ["--text", ["--text-color", "--text-underline-offset", "--text-indent", "--text-decoration-thickness", "--text-decoration-color"]]]);

    function a(e, t) {
        return (l.get(t) ?? []).some((t => e === t || e.startsWith(`${t}-`)))
    }

    var s = class {
        constructor(e = new Map, t = new Set([])) {
            this.values = e, this.keyframes = t
        }

        prefix = null;

        add(e, t, r = 0) {
            if (e.endsWith("-*")) {
                if ("initial" !== t) throw new Error(`Invalid theme value \`${t}\` for namespace \`${e}\``);
                "--*" === e ? this.values.clear() : this.clearNamespace(e.slice(0, -2), 0)
            }
            if (4 & r) {
                let t = this.values.get(e);
                if (t && !(4 & t.options)) return
            }
            "initial" === t ? this.values.delete(e) : this.values.set(e, {value: t, options: r})
        }

        keysInNamespaces(e) {
            let t = [];
            for (let r of e) {
                let e = `${r}-`;
                for (let n of this.values.keys()) n.startsWith(e) && -1 === n.indexOf("--", 2) && (a(n, r) || t.push(n.slice(e.length)))
            }
            return t
        }

        get(e) {
            for (let t of e) {
                let e = this.values.get(t);
                if (e) return e.value
            }
            return null
        }

        hasDefault(e) {
            return !(4 & ~this.getOptions(e))
        }

        getOptions(e) {
            return e = i(this.#e(e)), this.values.get(e)?.options ?? 0
        }

        entries() {
            return this.prefix ? Array.from(this.values, (e => (e[0] = this.prefixKey(e[0]), e))) : this.values.entries()
        }

        prefixKey(e) {
            return this.prefix ? `--${this.prefix}-${e.slice(2)}` : e
        }

        #e(e) {
            return this.prefix ? `--${e.slice(3 + this.prefix.length)}` : e
        }

        clearNamespace(e, t) {
            let r = l.get(e) ?? [];
            e:for (let n of this.values.keys()) if (n.startsWith(e)) {
                if (0 !== t && (this.getOptions(n) & t) !== t) continue;
                for (let e of r) if (n.startsWith(e)) continue e;
                this.values.delete(n)
            }
        }

        #t(e, t) {
            for (let r of t) {
                let t = null !== e ? `${r}-${e}` : r;
                if (!this.values.has(t)) {
                    if (null === e || !e.includes(".")) continue;
                    if (t = `${r}-${e.replaceAll(".", "_")}`, !this.values.has(t)) continue
                }
                if (!a(t, r)) return t
            }
            return null
        }

        #r(e) {
            let t = this.values.get(e);
            if (!t) return null;
            let r = null;
            return 2 & t.options && (r = t.value), `var(${o(this.prefixKey(e))}${r ? `, ${r}` : ""})`
        }

        markUsedVariable(e) {
            let t = i(this.#e(e)), r = this.values.get(t);
            r && (r.options |= 16)
        }

        resolve(e, t) {
            let r = this.#t(e, t);
            if (!r) return null;
            let n = this.values.get(r);
            return 1 & n.options ? n.value : this.#r(r)
        }

        resolveValue(e, t) {
            let r = this.#t(e, t);
            return r ? this.values.get(r).value : null
        }

        resolveWith(e, t, r = []) {
            let n = this.#t(e, t);
            if (!n) return null;
            let o = {};
            for (let e of r) {
                let t = `${n}${e}`, r = this.values.get(t);
                r && (1 & r.options ? o[e] = r.value : o[e] = this.#r(t))
            }
            let i = this.values.get(n);
            return 1 & i.options ? [i.value, o] : [this.#r(n), o]
        }

        namespace(e) {
            let t = new Map, r = `${e}-`;
            for (let [n, o] of this.values) n === e ? t.set(null, o.value) : n.startsWith(`${r}-`) ? t.set(n.slice(e.length), o.value) : n.startsWith(r) && t.set(n.slice(r.length), o.value);
            return t
        }

        addKeyframes(e) {
            this.keyframes.add(e)
        }

        getKeyframes() {
            return Array.from(this.keyframes)
        }
    }, c = class extends Map {
        constructor(e) {
            super(), this.factory = e
        }

        get(e) {
            let t = super.get(e);
            return void 0 === t && (t = this.factory(e, this), this.set(e, t)), t
        }
    };

    function u(e) {
        return {kind: "word", value: e}
    }

    function d(e, t) {
        return {kind: "function", value: e, nodes: t}
    }

    function f(e) {
        return {kind: "separator", value: e}
    }

    function h(e, t, r = null) {
        for (let n = 0; n < e.length; n++) {
            let o = e[n], i = !1, l = 0, a = t(o, {
                parent: r, replaceWith(t) {
                    i = !0, Array.isArray(t) ? 0 === t.length ? (e.splice(n, 1), l = 0) : 1 === t.length ? (e[n] = t[0], l = 1) : (e.splice(n, 1, ...t), l = t.length) : e[n] = t
                }
            }) ?? 0;
            if (i) 0 === a ? n-- : n += l - 1; else {
                if (2 === a) return 2;
                if (1 !== a && "function" === o.kind && 2 === h(o.nodes, t, o)) return 2
            }
        }
    }

    function p(e) {
        let t = "";
        for (let r of e) switch (r.kind) {
            case"word":
            case"separator":
                t += r.value;
                break;
            case"function":
                t += r.value + "(" + p(r.nodes) + ")"
        }
        return t
    }

    function m(e) {
        e = e.replaceAll("\r\n", "\n");
        let t, r = [], n = [], o = null, i = "";
        for (let l = 0; l < e.length; l++) {
            let a = e.charCodeAt(l);
            switch (a) {
                case 92:
                    i += e[l] + e[l + 1], l++;
                    break;
                case 58:
                case 44:
                case 61:
                case 62:
                case 60:
                case 10:
                case 47:
                case 32:
                case 9: {
                    if (i.length > 0) {
                        let e = u(i);
                        o ? o.nodes.push(e) : r.push(e), i = ""
                    }
                    let n = l, a = l + 1;
                    for (; a < e.length && (t = e.charCodeAt(a), 58 === t || 44 === t || 61 === t || 62 === t || 60 === t || 10 === t || 47 === t || 32 === t || 9 === t); a++) ;
                    l = a - 1;
                    let s = f(e.slice(n, a));
                    o ? o.nodes.push(s) : r.push(s);
                    break
                }
                case 39:
                case 34: {
                    let r = l;
                    for (let r = l + 1; r < e.length; r++) if (t = e.charCodeAt(r), 92 === t) r += 1; else if (t === a) {
                        l = r;
                        break
                    }
                    i += e.slice(r, l + 1);
                    break
                }
                case 40: {
                    let e = d(i, []);
                    i = "", o ? o.nodes.push(e) : r.push(e), n.push(e), o = e;
                    break
                }
                case 41: {
                    let e = n.pop();
                    if (i.length > 0) {
                        let t = u(i);
                        e.nodes.push(t), i = ""
                    }
                    o = n.length > 0 ? n[n.length - 1] : null;
                    break
                }
                default:
                    i += String.fromCharCode(a)
            }
        }
        return i.length > 0 && r.push(u(i)), r
    }

    function g(e) {
        let t = [];
        return h(m(e), (e => {
            if ("function" === e.kind && "var" === e.value) return h(e.nodes, (e => {
                "word" !== e.kind || "-" !== e.value[0] || "-" !== e.value[1] || t.push(e.value)
            })), 1
        })), t
    }

    var v = 64;

    function b(e, t = []) {
        return {kind: "rule", selector: e, nodes: t}
    }

    function w(e, t = "", r = []) {
        return {kind: "at-rule", name: e, params: t, nodes: r}
    }

    function k(e, t = []) {
        return e.charCodeAt(0) === v ? r(e, t) : b(e, t)
    }

    function y(e, t, r = !1) {
        return {kind: "declaration", property: e, value: t, important: r}
    }

    function x(e) {
        return {kind: "comment", value: e}
    }

    function $(e, t) {
        return {kind: "context", context: e, nodes: t}
    }

    function A(e) {
        return {kind: "at-root", nodes: e}
    }

    function z(e, t, r = [], n = {}) {
        for (let o = 0; o < e.length; o++) {
            let i = e[o], l = r[r.length - 1] ?? null;
            if ("context" === i.kind) {
                if (2 === z(i.nodes, t, r, {...n, ...i.context})) return 2;
                continue
            }
            r.push(i);
            let a = !1, s = 0, c = t(i, {
                parent: l, context: n, path: r, replaceWith(t) {
                    a = !0, Array.isArray(t) ? 0 === t.length ? (e.splice(o, 1), s = 0) : 1 === t.length ? (e[o] = t[0], s = 1) : (e.splice(o, 1, ...t), s = t.length) : (e[o] = t, s = 1)
                }
            }) ?? 0;
            if (r.pop(), a) 0 === c ? o-- : o += s - 1; else {
                if (2 === c) return 2;
                if (1 !== c && "nodes" in i) {
                    r.push(i);
                    let e = z(i.nodes, t, r, n);
                    if (r.pop(), 2 === e) return 2
                }
            }
        }
    }

    function C(e, t, r = [], n = {}) {
        for (let o = 0; o < e.length; o++) {
            let i = e[o], l = r[r.length - 1] ?? null;
            if ("rule" === i.kind || "at-rule" === i.kind) r.push(i), C(i.nodes, t, r, n), r.pop(); else if ("context" === i.kind) {
                C(i.nodes, t, r, {...n, ...i.context});
                continue
            }
            r.push(i), t(i, {
                parent: l, context: n, path: r, replaceWith(t) {
                    Array.isArray(t) ? 0 === t.length ? e.splice(o, 1) : 1 === t.length ? e[o] = t[0] : e.splice(o, 1, ...t) : e[o] = t, o += t.length - 1
                }
            }), r.pop()
        }
    }

    function T(e, t) {
        let r = [], n = new Set, o = new c((() => new Set)), i = new Set, l = new Set, a = new c((() => new Set));

        function s(e, c, u = {}, d = 0) {
            if ("declaration" === e.kind) {
                if ("--tw-sort" === e.property || void 0 === e.value || null === e.value) return;
                if (u.theme && "-" === e.property[0] && "-" === e.property[1] && (u.keyframes || o.get(c).add(e)), e.value.includes("var(")) if (u.theme && "-" === e.property[0] && "-" === e.property[1]) for (let t of g(e.value)) a.get(t).add(e.property); else t.trackUsedVariables(e.value);
                if ("animation" === e.property) {
                    let t = e.value.split(/\s+/);
                    for (let e of t) l.add(e)
                }
                c.push(e)
            } else if ("rule" === e.kind) if ("&" === e.selector) for (let t of e.nodes) {
                let e = [];
                s(t, e, u, d + 1), e.length > 0 && c.push(...e)
            } else {
                let t = {...e, nodes: []};
                for (let r of e.nodes) s(r, t.nodes, u, d + 1);
                t.nodes.length > 0 && c.push(t)
            } else if ("at-rule" === e.kind && "@property" === e.name && 0 === d) {
                if (n.has(e.params)) return;
                n.add(e.params);
                let t = {...e, nodes: []};
                for (let r of e.nodes) s(r, t.nodes, u, d + 1);
                c.push(t)
            } else if ("at-rule" === e.kind) {
                "@keyframes" === e.name && (u = {...u, keyframes: !0});
                let t = {...e, nodes: []};
                for (let r of e.nodes) s(r, t.nodes, u, d + 1);
                "@keyframes" === e.name && u.theme && i.add(t), (t.nodes.length > 0 || "@layer" === t.name || "@charset" === t.name || "@custom-media" === t.name || "@namespace" === t.name || "@import" === t.name) && c.push(t)
            } else if ("at-root" === e.kind) for (let t of e.nodes) {
                let e = [];
                s(t, e, u, 0);
                for (let t of e) r.push(t)
            } else if ("context" === e.kind) {
                if (e.context.reference) return;
                for (let t of e.nodes) s(t, c, {...u, ...e.context}, d)
            } else "comment" === e.kind && c.push(e)
        }

        let u = [];
        for (let t of e) s(t, u, {}, 0);
        e:for (let [e, r] of o) for (let n of r) {
            if (S(n.property, t.theme, a)) {
                if (n.property.startsWith(t.theme.prefixKey("--animate-"))) {
                    let e = n.value.split(/\s+/);
                    for (let t of e) l.add(t)
                }
                continue
            }
            let r = e.indexOf(n);
            if (e.splice(r, 1), 0 === e.length) {
                let t = K(u, (t => "rule" === t.kind && t.nodes === e));
                if (!t || 0 === t.length) continue e;
                for (t.unshift({kind: "at-root", nodes: u}); ;) {
                    let e = t.pop();
                    if (!e) break;
                    let r = t[t.length - 1];
                    if (!r || "at-root" !== r.kind && "at-rule" !== r.kind) break;
                    let n = r.nodes.indexOf(e);
                    if (-1 === n) break;
                    r.nodes.splice(n, 1)
                }
                continue e
            }
        }
        for (let e of i) if (!l.has(e.params)) {
            let t = r.indexOf(e);
            r.splice(t, 1)
        }
        return u.concat(r)
    }

    function j(e) {
        function t(e, r = 0) {
            let n = "", o = "  ".repeat(r);
            if ("declaration" === e.kind) n += `${o}${e.property}: ${e.value}${e.important ? " !important" : ""};\n`; else if ("rule" === e.kind) {
                n += `${o}${e.selector} {\n`;
                for (let o of e.nodes) n += t(o, r + 1);
                n += `${o}}\n`
            } else if ("at-rule" === e.kind) {
                if (0 === e.nodes.length) return `${o}${e.name} ${e.params};\n`;
                n += `${o}${e.name}${e.params ? ` ${e.params} ` : " "}{\n`;
                for (let o of e.nodes) n += t(o, r + 1);
                n += `${o}}\n`
            } else if ("comment" === e.kind) n += `${o}/*${e.value}*/\n`; else if ("context" === e.kind || "at-root" === e.kind) return "";
            return n
        }

        let r = "";
        for (let n of e) {
            let e = t(n);
            "" !== e && (r += e)
        }
        return r
    }

    function K(e, t) {
        let r = [];
        return z(e, ((e, {path: n}) => {
            if (t(e)) return r = [...n], 2
        })), r
    }

    function S(e, t, r, n = new Set) {
        if (n.has(e) || (n.add(e), 24 & t.getOptions(e))) return !0;
        {
            let o = r.get(e) ?? [];
            for (let e of o) if (S(e, t, r, n)) return !0
        }
        return !1
    }

    var E = ["calc", "min", "max", "clamp", "mod", "rem", "sin", "cos", "tan", "asin", "acos", "atan", "atan2", "pow", "sqrt", "hypot", "log", "exp", "round"],
        V = ["anchor-size"], N = new RegExp(`(${V.join("|")})\\(`, "g");

    function O(e) {
        return -1 !== e.indexOf("(") && E.some((t => e.includes(`${t}(`)))
    }

    function F(e) {
        if (-1 === e.indexOf("(")) return U(e);
        let t = m(e);
        return W(t), e = function (e) {
            if (!E.some((t => e.includes(t)))) return e;
            let t = !1;
            V.some((t => e.includes(t))) && (N.lastIndex = 0, e = e.replace(N, ((e, r) => (t = !0, `$${V.indexOf(r)}$(`))));
            let r = "", n = [];
            for (let t = 0; t < e.length; t++) {
                let o = e[t];
                if ("(" !== o) if (")" === o) r += o, n.shift(); else {
                    if ("," === o && n[0]) {
                        r += ", ";
                        continue
                    }
                    if (" " === o && n[0] && " " === r[r.length - 1]) continue;
                    if ("+" !== o && "*" !== o && "/" !== o && "-" !== o || !n[0]) if (n[0] && e.startsWith("to-zero", t)) {
                        let n = t;
                        t += 7, r += e.slice(n, t + 1)
                    } else r += o; else {
                        let n = r.trimEnd(), i = n[n.length - 1];
                        if ("+" === i || "*" === i || "/" === i || "-" === i) {
                            r += o;
                            continue
                        }
                        if ("(" === i || "," === i) {
                            r += o;
                            continue
                        }
                        " " === e[t - 1] ? r += `${o} ` : r += ` ${o} `
                    }
                } else {
                    r += o;
                    let i = t;
                    for (let r = t - 1; r >= 0; r--) {
                        let t = e.charCodeAt(r);
                        if (t >= 48 && t <= 57) i = r; else {
                            if (!(t >= 97 && t <= 122)) break;
                            i = r
                        }
                    }
                    let l = e.slice(i, t);
                    if (E.includes(l)) {
                        n.unshift(!0);
                        continue
                    }
                    if (n[0] && "" === l) {
                        n.unshift(!0);
                        continue
                    }
                    n.unshift(!1)
                }
            }
            return t ? r.replace(/\$(\d+)\$/g, ((e, t) => V[t] ?? e)) : r
        }(e = p(t)), e
    }

    function U(e, t = !1) {
        let r = "";
        for (let n = 0; n < e.length; n++) {
            let o = e[n];
            "\\" === o && "_" === e[n + 1] ? (r += "_", n += 1) : r += "_" !== o || t ? o : " "
        }
        return r
    }

    function W(e) {
        for (let t of e) switch (t.kind) {
            case"function":
                if ("url" === t.value || t.value.endsWith("_url")) {
                    t.value = U(t.value);
                    break
                }
                if ("var" === t.value || t.value.endsWith("_var") || "theme" === t.value || t.value.endsWith("_theme")) {
                    t.value = U(t.value);
                    for (let e = 0; e < t.nodes.length; e++) 0 != e || "word" !== t.nodes[e].kind ? W([t.nodes[e]]) : t.nodes[e].value = U(t.nodes[e].value, !0);
                    break
                }
                t.value = U(t.value), W(t.nodes);
                break;
            case"separator":
            case"word":
                t.value = U(t.value);
                break;
            default:
                D(t)
        }
    }

    function D(e) {
        throw new Error(`Unexpected value: ${e}`)
    }

    var _ = new Uint8Array(256);

    function B(e, t) {
        let r = 0, n = [], o = 0, i = e.length, l = t.charCodeAt(0);
        for (let t = 0; t < i; t++) {
            let a = e.charCodeAt(t);
            if (0 !== r || a !== l) switch (a) {
                case 92:
                    t += 1;
                    break;
                case 39:
                case 34:
                    for (; ++t < i;) {
                        let r = e.charCodeAt(t);
                        if (92 !== r) {
                            if (r === a) break
                        } else t += 1
                    }
                    break;
                case 40:
                    _[r] = 41, r++;
                    break;
                case 91:
                    _[r] = 93, r++;
                    break;
                case 123:
                    _[r] = 125, r++;
                    break;
                case 93:
                case 125:
                case 41:
                    r > 0 && a === _[r - 1] && r--
            } else n.push(e.slice(o, t)), o = t + 1
        }
        return n.push(e.slice(o)), n
    }

    function L(e) {
        if ("[" === e[0] && "]" === e[e.length - 1]) {
            let t = F(e.slice(1, -1));
            return 0 === t.length || 0 === t.trim().length ? null : {kind: "arbitrary", value: t}
        }
        if ("(" === e[0] && ")" === e[e.length - 1]) {
            let t = F(e.slice(1, -1));
            return 0 === t.length || 0 === t.trim().length || "-" !== t[0] && "-" !== t[1] ? null : {
                kind: "arbitrary",
                value: `var(${t})`
            }
        }
        return {kind: "named", value: e}
    }

    function* M(e, t) {
        t(e) && (yield[e, null]);
        let r = e.lastIndexOf("-");
        if (-1 !== r) do {
            let n = e.slice(0, r);
            if (t(n)) {
                let t = [n, e.slice(r + 1)];
                if ("" === t[1]) break;
                yield t
            }
            r = e.lastIndexOf("-", r - 1)
        } while (r > 0); else "@" === e[0] && t("@") && (yield["@", e.slice(1)])
    }

    function R(e, t, r) {
        if (e === t) return 0;
        let n = e.indexOf("("), o = t.indexOf("("), i = -1 === n ? e.replace(/[\d.]+/g, "") : e.slice(0, n),
            l = -1 === o ? t.replace(/[\d.]+/g, "") : t.slice(0, o),
            a = (i === l ? 0 : i < l ? -1 : 1) || ("asc" === r ? parseInt(e) - parseInt(t) : parseInt(t) - parseInt(e));
        return Number.isNaN(a) ? e < t ? -1 : 1 : a
    }

    var I = new Set(["black", "silver", "gray", "white", "maroon", "red", "purple", "fuchsia", "green", "lime", "olive", "yellow", "navy", "blue", "teal", "aqua", "aliceblue", "antiquewhite", "aqua", "aquamarine", "azure", "beige", "bisque", "black", "blanchedalmond", "blue", "blueviolet", "brown", "burlywood", "cadetblue", "chartreuse", "chocolate", "coral", "cornflowerblue", "cornsilk", "crimson", "cyan", "darkblue", "darkcyan", "darkgoldenrod", "darkgray", "darkgreen", "darkgrey", "darkkhaki", "darkmagenta", "darkolivegreen", "darkorange", "darkorchid", "darkred", "darksalmon", "darkseagreen", "darkslateblue", "darkslategray", "darkslategrey", "darkturquoise", "darkviolet", "deeppink", "deepskyblue", "dimgray", "dimgrey", "dodgerblue", "firebrick", "floralwhite", "forestgreen", "fuchsia", "gainsboro", "ghostwhite", "gold", "goldenrod", "gray", "green", "greenyellow", "grey", "honeydew", "hotpink", "indianred", "indigo", "ivory", "khaki", "lavender", "lavenderblush", "lawngreen", "lemonchiffon", "lightblue", "lightcoral", "lightcyan", "lightgoldenrodyellow", "lightgray", "lightgreen", "lightgrey", "lightpink", "lightsalmon", "lightseagreen", "lightskyblue", "lightslategray", "lightslategrey", "lightsteelblue", "lightyellow", "lime", "limegreen", "linen", "magenta", "maroon", "mediumaquamarine", "mediumblue", "mediumorchid", "mediumpurple", "mediumseagreen", "mediumslateblue", "mediumspringgreen", "mediumturquoise", "mediumvioletred", "midnightblue", "mintcream", "mistyrose", "moccasin", "navajowhite", "navy", "oldlace", "olive", "olivedrab", "orange", "orangered", "orchid", "palegoldenrod", "palegreen", "paleturquoise", "palevioletred", "papayawhip", "peachpuff", "peru", "pink", "plum", "powderblue", "purple", "rebeccapurple", "red", "rosybrown", "royalblue", "saddlebrown", "salmon", "sandybrown", "seagreen", "seashell", "sienna", "silver", "skyblue", "slateblue", "slategray", "slategrey", "snow", "springgreen", "steelblue", "tan", "teal", "thistle", "tomato", "turquoise", "violet", "wheat", "white", "whitesmoke", "yellow", "yellowgreen", "transparent", "currentcolor", "canvas", "canvastext", "linktext", "visitedtext", "activetext", "buttonface", "buttontext", "buttonborder", "field", "fieldtext", "highlight", "highlighttext", "selecteditem", "selecteditemtext", "mark", "marktext", "graytext", "accentcolor", "accentcolortext"]),
        q = /^(rgba?|hsla?|hwb|color|(ok)?(lab|lch)|light-dark|color-mix)\(/i;
    var P = {
        color: function (e) {
            return 35 === e.charCodeAt(0) || q.test(e) || I.has(e.toLowerCase())
        }, length: oe, percentage: te, ratio: function (e) {
            return re.test(e) || O(e)
        }, number: function (e) {
            return Q.test(e) || O(e)
        }, integer: ae, url: Z, position: function (e) {
            let t = 0;
            for (let r of B(e, " ")) if ("center" !== r && "top" !== r && "right" !== r && "bottom" !== r && "left" !== r) {
                if (!r.startsWith("var(")) {
                    if (oe(r) || te(r)) {
                        t += 1;
                        continue
                    }
                    return !1
                }
            } else t += 1;
            return t > 0
        }, "bg-size": function (e) {
            let t = 0;
            for (let r of B(e, ",")) {
                if ("cover" === r || "contain" === r) {
                    t += 1;
                    continue
                }
                let e = B(r, " ");
                if (1 !== e.length && 2 !== e.length) return !1;
                e.every((e => "auto" === e || oe(e) || te(e))) && (t += 1)
            }
            return t > 0
        }, "line-width": function (e) {
            return "thin" === e || "medium" === e || "thick" === e
        }, image: function (e) {
            let t = 0;
            for (let r of B(e, ",")) if (!r.startsWith("var(")) {
                if (Z(r)) {
                    t += 1;
                    continue
                }
                if (X.test(r)) {
                    t += 1;
                    continue
                }
                if (G.test(r)) {
                    t += 1;
                    continue
                }
                return !1
            }
            return t > 0
        }, "family-name": function (e) {
            let t = 0;
            for (let r of B(e, ",")) {
                let e = r.charCodeAt(0);
                if (e >= 48 && e <= 57) return !1;
                r.startsWith("var(") || (t += 1)
            }
            return t > 0
        }, "generic-name": function (e) {
            return "serif" === e || "sans-serif" === e || "monospace" === e || "cursive" === e || "fantasy" === e || "system-ui" === e || "ui-serif" === e || "ui-sans-serif" === e || "ui-monospace" === e || "ui-rounded" === e || "math" === e || "emoji" === e || "fangsong" === e
        }, "absolute-size": function (e) {
            return "xx-small" === e || "x-small" === e || "small" === e || "medium" === e || "large" === e || "x-large" === e || "xx-large" === e || "xxx-large" === e
        }, "relative-size": function (e) {
            return "larger" === e || "smaller" === e
        }, angle: function (e) {
            return ie.test(e)
        }, vector: function (e) {
            return le.test(e)
        }
    };

    function H(e, t) {
        if (e.startsWith("var(")) return null;
        for (let r of t) if (P[r]?.(e)) return r;
        return null
    }

    var Y = /^url\(.*\)$/;

    function Z(e) {
        return Y.test(e)
    }

    var G = /^(?:element|image|cross-fade|image-set)\(/, X = /^(repeating-)?(conic|linear|radial)-gradient\(/;
    var J = /[+-]?\d*\.?\d+(?:[eE][+-]?\d+)?/, Q = new RegExp(`^${J.source}$`);
    var ee = new RegExp(`^${J.source}%$`);

    function te(e) {
        return ee.test(e) || O(e)
    }

    var re = new RegExp(`^${J.source}s*/s*${J.source}$`);
    var ne = new RegExp(`^${J.source}(${["cm", "mm", "Q", "in", "pc", "pt", "px", "em", "ex", "ch", "rem", "lh", "rlh", "vw", "vh", "vmin", "vmax", "vb", "vi", "svw", "svh", "lvw", "lvh", "dvw", "dvh", "cqw", "cqh", "cqi", "cqb", "cqmin", "cqmax"].join("|")})$`);

    function oe(e) {
        return ne.test(e) || O(e)
    }

    var ie = new RegExp(`^${J.source}(${["deg", "rad", "grad", "turn"].join("|")})$`);
    var le = new RegExp(`^${J.source} +${J.source} +${J.source}$`);

    function ae(e) {
        let t = Number(e);
        return Number.isInteger(t) && t >= 0 && String(t) === String(e)
    }

    function se(e) {
        let t = Number(e);
        return Number.isInteger(t) && t > 0 && String(t) === String(e)
    }

    function ce(e) {
        return de(e, .25)
    }

    function ue(e) {
        return de(e, .25)
    }

    function de(e, t) {
        let r = Number(e);
        return r >= 0 && r % t == 0 && String(r) === String(e)
    }

    var fe = new Set(["inset", "inherit", "initial", "revert", "unset"]), he = /^-?(\d+|\.\d+)(.*?)$/g;

    function pe(e, t) {
        return B(e, ",").map((e => {
            let r = B(e = e.trim(), " ").filter((e => "" !== e.trim())), n = null, o = null, i = null;
            for (let e of r) fe.has(e) || (he.test(e) ? (null === o ? o = e : null === i && (i = e), he.lastIndex = 0) : null === n && (n = e));
            if (null === o || null === i) return e;
            let l = t(n ?? "currentcolor");
            return null !== n ? e.replace(n, l) : `${e} ${l}`
        })).join(", ")
    }

    var me = /^-?[a-z][a-zA-Z0-9/%._-]*$/, ge = /^-?[a-z][a-zA-Z0-9/%._-]*-\*$/, ve = class {
        utilities = new c((() => []));
        completions = new Map;

        static(e, t) {
            this.utilities.get(e).push({kind: "static", compileFn: t})
        }

        functional(e, t, r) {
            this.utilities.get(e).push({kind: "functional", compileFn: t, options: r})
        }

        has(e, t) {
            return this.utilities.has(e) && this.utilities.get(e).some((e => e.kind === t))
        }

        get(e) {
            return this.utilities.has(e) ? this.utilities.get(e) : []
        }

        getCompletions(e) {
            return this.completions.get(e)?.() ?? []
        }

        suggest(e, t) {
            this.completions.set(e, t)
        }

        keys(e) {
            let t = [];
            for (let [r, n] of this.utilities.entries()) for (let o of n) if (o.kind === e) {
                t.push(r);
                break
            }
            return t
        }
    };

    function be(e, t, r) {
        return w("@property", e, [y("syntax", r ? `"${r}"` : '"*"'), y("inherits", "false"), ...t ? [y("initial-value", t)] : []])
    }

    function we(e, t) {
        if (null === t) return e;
        let r = Number(t);
        return Number.isNaN(r) || (t = 100 * r + "%"), `color-mix(in oklab, ${e} ${t}, transparent)`
    }

    function ke(e, t, r) {
        if (!t) return e;
        if ("arbitrary" === t.kind) return we(e, t.value);
        let n = r.resolve(t.value, ["--opacity"]);
        return n ? we(e, n) : ue(t.value) ? we(e, `${t.value}%`) : null
    }

    function ye(e, t, r) {
        let n = null;
        switch (e.value.value) {
            case"inherit":
                n = "inherit";
                break;
            case"transparent":
                n = "transparent";
                break;
            case"current":
                n = "currentColor";
                break;
            default:
                n = t.resolve(e.value.value, r)
        }
        return n ? ke(n, e.modifier, t) : null
    }

    function xe(e, t, r) {
        for (let n of t.nodes) if ("named" === e.kind && "word" === n.kind && "-" === n.value[0] && "-" === n.value[1]) {
            let t = n.value;
            if (t.endsWith("-*")) {
                t = t.slice(0, -2);
                let n = r.theme.resolve(e.value, [t]);
                if (n) return {nodes: m(n)}
            } else {
                let n = t.split("-*");
                if (n.length <= 1) continue;
                let o = [n.shift()], i = r.theme.resolveWith(e.value, o, n);
                if (i) {
                    let [, e = {}] = i;
                    {
                        let t = e[n.pop()];
                        if (t) return {nodes: m(t)}
                    }
                }
            }
        } else {
            if ("named" === e.kind && "word" === n.kind) {
                if ("number" !== n.value && "integer" !== n.value && "ratio" !== n.value && "percentage" !== n.value) continue;
                let t = "ratio" === n.value && "fraction" in e ? e.fraction : e.value;
                if (!t) continue;
                let r = H(t, [n.value]);
                if (null === r) continue;
                if ("ratio" === r) {
                    let [e, r] = B(t, "/");
                    if (!ae(e) || !ae(r)) continue
                } else {
                    if ("number" === r && !ce(t)) continue;
                    if ("percentage" === r && !ae(t.slice(0, -1))) continue
                }
                return {nodes: m(t), ratio: "ratio" === r}
            }
            if ("arbitrary" === e.kind && "word" === n.kind && "[" === n.value[0] && "]" === n.value[n.value.length - 1]) {
                let t = n.value.slice(1, -1);
                if ("*" === t) return {nodes: m(e.value)};
                if ("dataType" in e && e.dataType && e.dataType !== t) continue;
                if ("dataType" in e && e.dataType) return {nodes: m(e.value)};
                if (null !== H(e.value, [t])) return {nodes: m(e.value)}
            }
        }
    }

    var $e = {
        "--alpha": function (e, t, ...r) {
            let [n, o] = B(t, "/").map((e => e.trim()));
            if (!n || !o) throw new Error(`The --alpha(…) function requires a color and an alpha value, e.g.: \`--alpha(${n || "var(--my-color)"} / ${o || "50%"})\``);
            if (r.length > 0) throw new Error(`The --alpha(…) function only accepts one argument, e.g.: \`--alpha(${n || "var(--my-color)"} / ${o || "50%"})\``);
            return we(n, o)
        }, "--spacing": function (e, t, ...r) {
            if (!t) throw new Error("The --spacing(…) function requires an argument, but received none.");
            if (r.length > 0) throw new Error(`The --spacing(…) function only accepts a single argument, but received ${r.length + 1}.`);
            let n = e.theme.resolve(null, ["--spacing"]);
            if (!n) throw new Error("The --spacing(…) function requires that the `--spacing` theme variable exists, but it was not found.");
            return `calc(${n} * ${t})`
        }, "--theme": function (e, t, ...r) {
            if (!t.startsWith("--")) throw new Error("The --theme(…) function can only be used with CSS variables from your theme.");
            return Ae(e, t, ...r)
        }, theme: Ae
    };

    function Ae(e, t, ...r) {
        t = function (e) {
            if ("'" !== e[0] && '"' !== e[0]) return e;
            let t = "", r = e[0];
            for (let n = 1; n < e.length - 1; n++) {
                let o = e[n], i = e[n + 1];
                "\\" !== o || i !== r && "\\" !== i ? t += o : (t += i, n++)
            }
            return t
        }(t);
        let n = e.resolveThemeValue(t);
        if (!n && r.length > 0) return r.join(", ");
        if (!n) throw new Error(`Could not resolve value for theme function: \`theme(${t})\`. Consider checking if the path is correct or provide a fallback value to silence this error.`);
        return n
    }

    var ze = new RegExp(Object.keys($e).map((e => `${e}\\(`)).join("|"));

    function Ce(e, t) {
        let r = 0;
        return z(e, (e => {
            if ("declaration" === e.kind && e.value && ze.test(e.value)) return r |= 8, void (e.value = Te(e.value, t));
            "at-rule" === e.kind && ("@media" === e.name || "@custom-media" === e.name || "@container" === e.name || "@supports" === e.name) && ze.test(e.params) && (r |= 8, e.params = Te(e.params, t))
        })), r
    }

    function Te(e, t) {
        let r = m(e);
        return h(r, ((e, {replaceWith: r}) => {
            if ("function" === e.kind && e.value in $e) {
                let n = B(p(e.nodes).trim(), ",").map((e => e.trim()));
                return r(m($e[e.value](t, ...n)))
            }
        })), p(r)
    }

    function je(e, t) {
        let r = e.length, n = t.length, o = r < n ? r : n;
        for (let r = 0; r < o; r++) {
            let n = e.charCodeAt(r), o = t.charCodeAt(r);
            if (n >= 48 && n <= 57 && o >= 48 && o <= 57) {
                let i = r, l = r + 1, a = r, s = r + 1;
                for (n = e.charCodeAt(l); n >= 48 && n <= 57;) n = e.charCodeAt(++l);
                for (o = t.charCodeAt(s); o >= 48 && o <= 57;) o = t.charCodeAt(++s);
                let c = e.slice(i, l), u = t.slice(a, s), d = Number(c) - Number(u);
                if (d) return d;
                if (c < u) return -1;
                if (c > u) return 1
            } else if (n !== o) return n - o
        }
        return e.length - t.length
    }

    var Ke = /^\d+\/\d+$/;

    function Se(e) {
        let t = [];
        for (let r of e.utilities.keys("static")) t.push({name: r, utility: r, fraction: !1, modifiers: []});
        for (let r of e.utilities.keys("functional")) {
            let n = e.utilities.getCompletions(r);
            for (let e of n) for (let n of e.values) {
                let o = null !== n && Ke.test(n), i = null === n ? r : `${r}-${n}`;
                t.push({
                    name: i,
                    utility: r,
                    fraction: o,
                    modifiers: e.modifiers
                }), e.supportsNegative && t.push({name: `-${i}`, utility: `-${r}`, fraction: o, modifiers: e.modifiers})
            }
        }
        return 0 === t.length ? [] : (t.sort(((e, t) => je(e.name, t.name))), function (e) {
            let t = [], r = null, n = new Map, o = new c((() => []));
            for (let i of e) {
                let {utility: e, fraction: l} = i;
                r || (r = {utility: e, items: []}, n.set(e, r)), e !== r.utility && (t.push(r), r = {
                    utility: e,
                    items: []
                }, n.set(e, r)), l ? o.get(e).push(i) : r.items.push(i)
            }
            r && t[t.length - 1] !== r && t.push(r);
            for (let [e, t] of o) {
                let r = n.get(e);
                r && r.items.push(...t)
            }
            let i = [];
            for (let e of t) for (let t of e.items) i.push([t.name, {modifiers: t.modifiers}]);
            return i
        }(t))
    }

    var Ee = /^@?[a-zA-Z0-9_-]*$/, Ve = class {
        compareFns = new Map;
        variants = new Map;
        completions = new Map;
        groupOrder = null;
        lastOrder = 0;

        static(e, t, {compounds: r, order: n} = {}) {
            this.set(e, {kind: "static", applyFn: t, compoundsWith: 0, compounds: r ?? 2, order: n})
        }

        fromAst(e, t) {
            let r = [];
            z(t, (e => {
                "rule" === e.kind ? r.push(e.selector) : "at-rule" === e.kind && "@slot" !== e.name && r.push(`${e.name} ${e.params}`)
            })), this.static(e, (e => {
                let r = structuredClone(t);
                Fe(r, e.nodes), e.nodes = r
            }), {compounds: Ne(r)})
        }

        functional(e, t, {compounds: r, order: n} = {}) {
            this.set(e, {kind: "functional", applyFn: t, compoundsWith: 0, compounds: r ?? 2, order: n})
        }

        compound(e, t, r, {compounds: n, order: o} = {}) {
            this.set(e, {kind: "compound", applyFn: r, compoundsWith: t, compounds: n ?? 2, order: o})
        }

        group(e, t) {
            this.groupOrder = this.nextOrder(), t && this.compareFns.set(this.groupOrder, t), e(), this.groupOrder = null
        }

        has(e) {
            return this.variants.has(e)
        }

        get(e) {
            return this.variants.get(e)
        }

        kind(e) {
            return this.variants.get(e)?.kind
        }

        compoundsWith(e, t) {
            let r = this.variants.get(e),
                n = "string" == typeof t ? this.variants.get(t) : "arbitrary" === t.kind ? {compounds: Ne([t.selector])} : this.variants.get(t.root);
            return !!(r && n && "compound" === r.kind && 0 !== n.compounds && 0 !== r.compoundsWith && r.compoundsWith & n.compounds)
        }

        suggest(e, t) {
            this.completions.set(e, t)
        }

        getCompletions(e) {
            return this.completions.get(e)?.() ?? []
        }

        compare(e, t) {
            if (e === t) return 0;
            if (null === e) return -1;
            if (null === t) return 1;
            if ("arbitrary" === e.kind && "arbitrary" === t.kind) return e.selector < t.selector ? -1 : 1;
            if ("arbitrary" === e.kind) return 1;
            if ("arbitrary" === t.kind) return -1;
            let r = this.variants.get(e.root).order, n = r - this.variants.get(t.root).order;
            if (0 !== n) return n;
            if ("compound" === e.kind && "compound" === t.kind) {
                let r = this.compare(e.variant, t.variant);
                return 0 !== r ? r : e.modifier && t.modifier ? e.modifier.value < t.modifier.value ? -1 : 1 : e.modifier ? 1 : t.modifier ? -1 : 0
            }
            let o = this.compareFns.get(r);
            if (void 0 !== o) return o(e, t);
            if (e.root !== t.root) return e.root < t.root ? -1 : 1;
            let i = e.value, l = t.value;
            return null === i ? -1 : null === l || "arbitrary" === i.kind && "arbitrary" !== l.kind ? 1 : "arbitrary" !== i.kind && "arbitrary" === l.kind || i.value < l.value ? -1 : 1
        }

        keys() {
            return this.variants.keys()
        }

        entries() {
            return this.variants.entries()
        }

        set(e, {kind: t, applyFn: r, compounds: n, compoundsWith: o, order: i}) {
            let l = this.variants.get(e);
            l ? Object.assign(l, {
                kind: t,
                applyFn: r,
                compounds: n
            }) : (void 0 === i && (this.lastOrder = this.nextOrder(), i = this.lastOrder), this.variants.set(e, {
                kind: t,
                applyFn: r,
                order: i,
                compoundsWith: o,
                compounds: n
            }))
        }

        nextOrder() {
            return this.groupOrder ?? this.lastOrder + 1
        }
    };

    function Ne(e) {
        let t = 0;
        for (let r of e) if ("@" !== r[0]) {
            if (r.includes("::")) return 0;
            t |= 2
        } else {
            if (!r.startsWith("@media") && !r.startsWith("@supports") && !r.startsWith("@container")) return 0;
            t |= 1
        }
        return t
    }

    function Oe(e) {
        if (e.includes("=")) {
            let [t, ...r] = B(e, "="), n = r.join("=").trim();
            if ("'" === n[0] || '"' === n[0]) return e;
            if (n.length > 1) {
                let e = n[n.length - 1];
                if (" " === n[n.length - 2] && ("i" === e || "I" === e || "s" === e || "S" === e)) return `${t}="${n.slice(0, -2)}" ${e}`
            }
            return `${t}="${n}"`
        }
        return e
    }

    function Fe(e, t) {
        z(e, ((e, {replaceWith: r}) => {
            if ("at-rule" === e.kind && "@slot" === e.name) r(t); else if ("at-rule" === e.kind && ("@keyframes" === e.name || "@property" === e.name)) return Object.assign(e, A([w(e.name, e.params, e.nodes)])), 1
        }))
    }

    function Ue(e) {
        let t = function (e) {
            let t = new ve;

            function r(r, n) {
                let o = /(\d+)_(\d+)/g;

                function* i(t) {
                    for (let r of e.keysInNamespaces(t)) yield r.replace(o, ((e, t, r) => `${t}.${r}`))
                }

                let l = ["1/2", "1/3", "2/3", "1/4", "2/4", "3/4", "1/5", "2/5", "3/5", "4/5", "1/6", "2/6", "3/6", "4/6", "5/6", "1/12", "2/12", "3/12", "4/12", "5/12", "6/12", "7/12", "8/12", "9/12", "10/12", "11/12"];
                t.suggest(r, (() => {
                    let e = [];
                    for (let t of n()) {
                        if ("string" == typeof t) {
                            e.push({values: [t], modifiers: []});
                            continue
                        }
                        let r = [...t.values ?? [], ...i(t.valueThemeKeys ?? [])],
                            n = [...t.modifiers ?? [], ...i(t.modifierThemeKeys ?? [])];
                        t.supportsFractions && r.push(...l), t.hasDefaultValue && r.unshift(null), e.push({
                            supportsNegative: t.supportsNegative,
                            values: r,
                            modifiers: n
                        })
                    }
                    return e
                }))
            }

            function n(e, r) {
                t.static(e, (() => r.map((e => "function" == typeof e ? e() : y(e[0], e[1])))))
            }

            function o(n, o) {
                function i({negative: t}) {
                    return r => {
                        let n = null;
                        if (r.value) if ("arbitrary" === r.value.kind) {
                            if (r.modifier) return;
                            n = r.value.value
                        } else {
                            if (n = e.resolve(r.value.fraction ?? r.value.value, o.themeKeys ?? []), null === n && o.supportsFractions && r.value.fraction) {
                                let [e, t] = B(r.value.fraction, "/");
                                if (!ae(e) || !ae(t)) return;
                                n = `calc(${r.value.fraction} * 100%)`
                            }
                            if (null === n && t && o.handleNegativeBareValue) {
                                if (n = o.handleNegativeBareValue(r.value), !n?.includes("/") && r.modifier) return;
                                if (null !== n) return o.handle(n)
                            }
                            if (null === n && o.handleBareValue && (n = o.handleBareValue(r.value), !n?.includes("/") && r.modifier)) return
                        } else {
                            if (r.modifier) return;
                            n = void 0 !== o.defaultValue ? o.defaultValue : e.resolve(null, o.themeKeys ?? [])
                        }
                        if (null !== n) return o.handle(t ? `calc(${n} * -1)` : n)
                    }
                }

                o.supportsNegative && t.functional(`-${n}`, i({negative: !0})), t.functional(n, i({negative: !1})), r(n, (() => [{
                    supportsNegative: o.supportsNegative,
                    valueThemeKeys: o.themeKeys ?? [],
                    hasDefaultValue: void 0 !== o.defaultValue && null !== o.defaultValue,
                    supportsFractions: o.supportsFractions
                }]))
            }

            function i(n, o) {
                t.functional(n, (t => {
                    if (!t.value) return;
                    let r = null;
                    return "arbitrary" === t.value.kind ? (r = t.value.value, r = ke(r, t.modifier, e)) : r = ye(t, e, o.themeKeys), null !== r ? o.handle(r) : void 0
                })), r(n, (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: o.themeKeys,
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
                }]))
            }

            function l(n, i, l, {supportsNegative: a = !1, supportsFractions: s = !1} = {}) {
                a && t.static(`-${n}-px`, (() => l("-1px"))), t.static(`${n}-px`, (() => l("1px"))), o(n, {
                    themeKeys: i,
                    supportsFractions: s,
                    supportsNegative: a,
                    defaultValue: null,
                    handleBareValue: ({value: t}) => {
                        let r = e.resolve(null, ["--spacing"]);
                        return r && ce(t) ? `calc(${r} * ${t})` : null
                    },
                    handleNegativeBareValue: ({value: t}) => {
                        let r = e.resolve(null, ["--spacing"]);
                        return r && ce(t) ? `calc(${r} * -${t})` : null
                    },
                    handle: l
                }), r(n, (() => [{
                    values: e.get(["--spacing"]) ? ["0", "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4", "5", "6", "7", "8", "9", "10", "11", "12", "14", "16", "20", "24", "28", "32", "36", "40", "44", "48", "52", "56", "60", "64", "72", "80", "96"] : [],
                    supportsNegative: a,
                    supportsFractions: s,
                    valueThemeKeys: i
                }]))
            }

            n("sr-only", [["position", "absolute"], ["width", "1px"], ["height", "1px"], ["padding", "0"], ["margin", "-1px"], ["overflow", "hidden"], ["clip", "rect(0, 0, 0, 0)"], ["white-space", "nowrap"], ["border-width", "0"]]), n("not-sr-only", [["position", "static"], ["width", "auto"], ["height", "auto"], ["padding", "0"], ["margin", "0"], ["overflow", "visible"], ["clip", "auto"], ["white-space", "normal"]]), n("pointer-events-none", [["pointer-events", "none"]]), n("pointer-events-auto", [["pointer-events", "auto"]]), n("visible", [["visibility", "visible"]]), n("invisible", [["visibility", "hidden"]]), n("collapse", [["visibility", "collapse"]]), n("static", [["position", "static"]]), n("fixed", [["position", "fixed"]]), n("absolute", [["position", "absolute"]]), n("relative", [["position", "relative"]]), n("sticky", [["position", "sticky"]]);
            for (let [e, t] of [["inset", "inset"], ["inset-x", "inset-inline"], ["inset-y", "inset-block"], ["start", "inset-inline-start"], ["end", "inset-inline-end"], ["top", "top"], ["right", "right"], ["bottom", "bottom"], ["left", "left"]]) n(`${e}-auto`, [[t, "auto"]]), n(`${e}-full`, [[t, "100%"]]), n(`-${e}-full`, [[t, "-100%"]]), l(e, ["--inset", "--spacing"], (e => [y(t, e)]), {
                supportsNegative: !0,
                supportsFractions: !0
            });
            n("isolate", [["isolation", "isolate"]]), n("isolation-auto", [["isolation", "auto"]]), n("z-auto", [["z-index", "auto"]]), o("z", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--z-index"],
                handle: e => [y("z-index", e)]
            }), r("z", (() => [{
                supportsNegative: !0,
                values: ["0", "10", "20", "30", "40", "50"],
                valueThemeKeys: ["--z-index"]
            }])), n("order-first", [["order", "-9999"]]), n("order-last", [["order", "9999"]]), n("order-none", [["order", "0"]]), o("order", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--order"],
                handle: e => [y("order", e)]
            }), r("order", (() => [{
                supportsNegative: !0,
                values: Array.from({length: 12}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--order"]
            }])), n("col-auto", [["grid-column", "auto"]]), o("col", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--grid-column"],
                handle: e => [y("grid-column", e)]
            }), n("col-span-full", [["grid-column", "1 / -1"]]), o("col-span", {
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                handle: e => [y("grid-column", `span ${e} / span ${e}`)]
            }), n("col-start-auto", [["grid-column-start", "auto"]]), o("col-start", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--grid-column-start"],
                handle: e => [y("grid-column-start", e)]
            }), n("col-end-auto", [["grid-column-end", "auto"]]), o("col-end", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--grid-column-end"],
                handle: e => [y("grid-column-end", e)]
            }), r("col-span", (() => [{
                values: Array.from({length: 12}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: []
            }])), r("col-start", (() => [{
                supportsNegative: !0,
                values: Array.from({length: 13}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--grid-column-start"]
            }])), r("col-end", (() => [{
                supportsNegative: !0,
                values: Array.from({length: 13}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--grid-column-end"]
            }])), n("row-auto", [["grid-row", "auto"]]), o("row", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--grid-row"],
                handle: e => [y("grid-row", e)]
            }), n("row-span-full", [["grid-row", "1 / -1"]]), o("row-span", {
                themeKeys: [],
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                handle: e => [y("grid-row", `span ${e} / span ${e}`)]
            }), n("row-start-auto", [["grid-row-start", "auto"]]), o("row-start", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--grid-row-start"],
                handle: e => [y("grid-row-start", e)]
            }), n("row-end-auto", [["grid-row-end", "auto"]]), o("row-end", {
                supportsNegative: !0,
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                themeKeys: ["--grid-row-end"],
                handle: e => [y("grid-row-end", e)]
            }), r("row-span", (() => [{
                values: Array.from({length: 12}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: []
            }])), r("row-start", (() => [{
                supportsNegative: !0,
                values: Array.from({length: 13}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--grid-row-start"]
            }])), r("row-end", (() => [{
                supportsNegative: !0,
                values: Array.from({length: 13}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--grid-row-end"]
            }])), n("float-start", [["float", "inline-start"]]), n("float-end", [["float", "inline-end"]]), n("float-right", [["float", "right"]]), n("float-left", [["float", "left"]]), n("float-none", [["float", "none"]]), n("clear-start", [["clear", "inline-start"]]), n("clear-end", [["clear", "inline-end"]]), n("clear-right", [["clear", "right"]]), n("clear-left", [["clear", "left"]]), n("clear-both", [["clear", "both"]]), n("clear-none", [["clear", "none"]]);
            for (let [e, t] of [["m", "margin"], ["mx", "margin-inline"], ["my", "margin-block"], ["ms", "margin-inline-start"], ["me", "margin-inline-end"], ["mt", "margin-top"], ["mr", "margin-right"], ["mb", "margin-bottom"], ["ml", "margin-left"]]) n(`${e}-auto`, [[t, "auto"]]), l(e, ["--margin", "--spacing"], (e => [y(t, e)]), {supportsNegative: !0});
            n("box-border", [["box-sizing", "border-box"]]), n("box-content", [["box-sizing", "content-box"]]), n("line-clamp-none", [["overflow", "visible"], ["display", "block"], ["-webkit-box-orient", "horizontal"], ["-webkit-line-clamp", "unset"]]), o("line-clamp", {
                themeKeys: ["--line-clamp"],
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                handle: e => [y("overflow", "hidden"), y("display", "-webkit-box"), y("-webkit-box-orient", "vertical"), y("-webkit-line-clamp", e)]
            }), r("line-clamp", (() => [{
                values: ["1", "2", "3", "4", "5", "6"],
                valueThemeKeys: ["--line-clamp"]
            }])), n("block", [["display", "block"]]), n("inline-block", [["display", "inline-block"]]), n("inline", [["display", "inline"]]), n("hidden", [["display", "none"]]), n("inline-flex", [["display", "inline-flex"]]), n("table", [["display", "table"]]), n("inline-table", [["display", "inline-table"]]), n("table-caption", [["display", "table-caption"]]), n("table-cell", [["display", "table-cell"]]), n("table-column", [["display", "table-column"]]), n("table-column-group", [["display", "table-column-group"]]), n("table-footer-group", [["display", "table-footer-group"]]), n("table-header-group", [["display", "table-header-group"]]), n("table-row-group", [["display", "table-row-group"]]), n("table-row", [["display", "table-row"]]), n("flow-root", [["display", "flow-root"]]), n("flex", [["display", "flex"]]), n("grid", [["display", "grid"]]), n("inline-grid", [["display", "inline-grid"]]), n("contents", [["display", "contents"]]), n("list-item", [["display", "list-item"]]), n("field-sizing-content", [["field-sizing", "content"]]), n("field-sizing-fixed", [["field-sizing", "fixed"]]), n("aspect-auto", [["aspect-ratio", "auto"]]), n("aspect-square", [["aspect-ratio", "1 / 1"]]), o("aspect", {
                themeKeys: ["--aspect"],
                handleBareValue: ({fraction: e}) => {
                    if (null === e) return null;
                    let [t, r] = B(e, "/");
                    return ae(t) && ae(r) ? e : null
                },
                handle: e => [y("aspect-ratio", e)]
            });
            for (let [e, t] of [["auto", "auto"], ["full", "100%"], ["svw", "100svw"], ["lvw", "100lvw"], ["dvw", "100dvw"], ["svh", "100svh"], ["lvh", "100lvh"], ["dvh", "100dvh"], ["min", "min-content"], ["max", "max-content"], ["fit", "fit-content"]]) n(`size-${e}`, [["--tw-sort", "size"], ["width", t], ["height", t]]), n(`w-${e}`, [["width", t]]), n(`h-${e}`, [["height", t]]), n(`min-w-${e}`, [["min-width", t]]), n(`min-h-${e}`, [["min-height", t]]), "auto" !== e && (n(`max-w-${e}`, [["max-width", t]]), n(`max-h-${e}`, [["max-height", t]]));
            n("w-screen", [["width", "100vw"]]), n("min-w-screen", [["min-width", "100vw"]]), n("max-w-screen", [["max-width", "100vw"]]), n("h-screen", [["height", "100vh"]]), n("min-h-screen", [["min-height", "100vh"]]), n("max-h-screen", [["max-height", "100vh"]]), n("max-w-none", [["max-width", "none"]]), n("max-h-none", [["max-height", "none"]]), l("size", ["--size", "--spacing"], (e => [y("--tw-sort", "size"), y("width", e), y("height", e)]), {supportsFractions: !0});
            for (let [e, t, r] of [["w", ["--width", "--spacing", "--container"], "width"], ["min-w", ["--min-width", "--spacing", "--container"], "min-width"], ["max-w", ["--max-width", "--spacing", "--container"], "max-width"], ["h", ["--height", "--spacing"], "height"], ["min-h", ["--min-height", "--height", "--spacing"], "min-height"], ["max-h", ["--max-height", "--height", "--spacing"], "max-height"]]) l(e, t, (e => [y(r, e)]), {supportsFractions: !0});
            t.static("container", (() => {
                let t = [...e.namespace("--breakpoint").values()];
                t.sort(((e, t) => R(e, t, "asc")));
                let r = [y("--tw-sort", "--tw-container-component"), y("width", "100%")];
                for (let e of t) r.push(w("@media", `(width >= ${e})`, [y("max-width", e)]));
                return r
            })), n("flex-auto", [["flex", "auto"]]), n("flex-initial", [["flex", "0 auto"]]), n("flex-none", [["flex", "none"]]), t.functional("flex", (e => {
                if (e.value) {
                    if ("arbitrary" === e.value.kind) return e.modifier ? void 0 : [y("flex", e.value.value)];
                    if (e.value.fraction) {
                        let [t, r] = B(e.value.fraction, "/");
                        return ae(t) && ae(r) ? [y("flex", `calc(${e.value.fraction} * 100%)`)] : void 0
                    }
                    if (ae(e.value.value)) return e.modifier ? void 0 : [y("flex", e.value.value)]
                }
            })), r("flex", (() => [{supportsFractions: !0}])), o("shrink", {
                defaultValue: "1",
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                handle: e => [y("flex-shrink", e)]
            }), o("grow", {
                defaultValue: "1",
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                handle: e => [y("flex-grow", e)]
            }), r("shrink", (() => [{
                values: ["0"],
                valueThemeKeys: [],
                hasDefaultValue: !0
            }])), r("grow", (() => [{
                values: ["0"],
                valueThemeKeys: [],
                hasDefaultValue: !0
            }])), n("basis-auto", [["flex-basis", "auto"]]), n("basis-full", [["flex-basis", "100%"]]), l("basis", ["--flex-basis", "--spacing", "--container"], (e => [y("flex-basis", e)]), {supportsFractions: !0}), n("table-auto", [["table-layout", "auto"]]), n("table-fixed", [["table-layout", "fixed"]]), n("caption-top", [["caption-side", "top"]]), n("caption-bottom", [["caption-side", "bottom"]]), n("border-collapse", [["border-collapse", "collapse"]]), n("border-separate", [["border-collapse", "separate"]]);
            let a = () => A([be("--tw-border-spacing-x", "0", "<length>"), be("--tw-border-spacing-y", "0", "<length>")]);
            l("border-spacing", ["--border-spacing", "--spacing"], (e => [a(), y("--tw-border-spacing-x", e), y("--tw-border-spacing-y", e), y("border-spacing", "var(--tw-border-spacing-x) var(--tw-border-spacing-y)")])), l("border-spacing-x", ["--border-spacing", "--spacing"], (e => [a(), y("--tw-border-spacing-x", e), y("border-spacing", "var(--tw-border-spacing-x) var(--tw-border-spacing-y)")])), l("border-spacing-y", ["--border-spacing", "--spacing"], (e => [a(), y("--tw-border-spacing-y", e), y("border-spacing", "var(--tw-border-spacing-x) var(--tw-border-spacing-y)")])), n("origin-center", [["transform-origin", "center"]]), n("origin-top", [["transform-origin", "top"]]), n("origin-top-right", [["transform-origin", "top right"]]), n("origin-right", [["transform-origin", "right"]]), n("origin-bottom-right", [["transform-origin", "bottom right"]]), n("origin-bottom", [["transform-origin", "bottom"]]), n("origin-bottom-left", [["transform-origin", "bottom left"]]), n("origin-left", [["transform-origin", "left"]]), n("origin-top-left", [["transform-origin", "top left"]]), o("origin", {
                themeKeys: ["--transform-origin"],
                handle: e => [y("transform-origin", e)]
            }), n("perspective-origin-center", [["perspective-origin", "center"]]), n("perspective-origin-top", [["perspective-origin", "top"]]), n("perspective-origin-top-right", [["perspective-origin", "top right"]]), n("perspective-origin-right", [["perspective-origin", "right"]]), n("perspective-origin-bottom-right", [["perspective-origin", "bottom right"]]), n("perspective-origin-bottom", [["perspective-origin", "bottom"]]), n("perspective-origin-bottom-left", [["perspective-origin", "bottom left"]]), n("perspective-origin-left", [["perspective-origin", "left"]]), n("perspective-origin-top-left", [["perspective-origin", "top left"]]), o("perspective-origin", {
                themeKeys: ["--perspective-origin"],
                handle: e => [y("perspective-origin", e)]
            }), n("perspective-none", [["perspective", "none"]]), o("perspective", {
                themeKeys: ["--perspective"],
                handle: e => [y("perspective", e)]
            });
            let s = () => A([be("--tw-translate-x", "0"), be("--tw-translate-y", "0"), be("--tw-translate-z", "0")]);
            n("translate-none", [["translate", "none"]]), n("-translate-full", [s, ["--tw-translate-x", "-100%"], ["--tw-translate-y", "-100%"], ["translate", "var(--tw-translate-x) var(--tw-translate-y)"]]), n("translate-full", [s, ["--tw-translate-x", "100%"], ["--tw-translate-y", "100%"], ["translate", "var(--tw-translate-x) var(--tw-translate-y)"]]), l("translate", ["--translate", "--spacing"], (e => [s(), y("--tw-translate-x", e), y("--tw-translate-y", e), y("translate", "var(--tw-translate-x) var(--tw-translate-y)")]), {
                supportsNegative: !0,
                supportsFractions: !0
            });
            for (let e of ["x", "y"]) n(`-translate-${e}-full`, [s, [`--tw-translate-${e}`, "-100%"], ["translate", "var(--tw-translate-x) var(--tw-translate-y)"]]), n(`translate-${e}-full`, [s, [`--tw-translate-${e}`, "100%"], ["translate", "var(--tw-translate-x) var(--tw-translate-y)"]]), l(`translate-${e}`, ["--translate", "--spacing"], (t => [s(), y(`--tw-translate-${e}`, t), y("translate", "var(--tw-translate-x) var(--tw-translate-y)")]), {
                supportsNegative: !0,
                supportsFractions: !0
            });
            l("translate-z", ["--translate", "--spacing"], (e => [s(), y("--tw-translate-z", e), y("translate", "var(--tw-translate-x) var(--tw-translate-y) var(--tw-translate-z)")]), {supportsNegative: !0}), n("translate-3d", [s, ["translate", "var(--tw-translate-x) var(--tw-translate-y) var(--tw-translate-z)"]]);
            let c = () => A([be("--tw-scale-x", "1"), be("--tw-scale-y", "1"), be("--tw-scale-z", "1")]);

            function u({negative: t}) {
                return r => {
                    if (!r.value || r.modifier) return;
                    let n;
                    return "arbitrary" === r.value.kind ? (n = r.value.value, [y("scale", n)]) : (n = e.resolve(r.value.value, ["--scale"]), !n && ae(r.value.value) && (n = `${r.value.value}%`), n ? (n = t ? `calc(${n} * -1)` : n, [c(), y("--tw-scale-x", n), y("--tw-scale-y", n), y("--tw-scale-z", n), y("scale", "var(--tw-scale-x) var(--tw-scale-y)")]) : void 0)
                }
            }

            n("scale-none", [["scale", "none"]]), t.functional("-scale", u({negative: !0})), t.functional("scale", u({negative: !1})), r("scale", (() => [{
                supportsNegative: !0,
                values: ["0", "50", "75", "90", "95", "100", "105", "110", "125", "150", "200"],
                valueThemeKeys: ["--scale"]
            }]));
            for (let e of ["x", "y", "z"]) o(`scale-${e}`, {
                supportsNegative: !0,
                themeKeys: ["--scale"],
                handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                handle: t => [c(), y(`--tw-scale-${e}`, t), y("scale", "var(--tw-scale-x) var(--tw-scale-y)" + ("z" === e ? " var(--tw-scale-z)" : ""))]
            }), r(`scale-${e}`, (() => [{
                supportsNegative: !0,
                values: ["0", "50", "75", "90", "95", "100", "105", "110", "125", "150", "200"],
                valueThemeKeys: ["--scale"]
            }]));

            function d({negative: t}) {
                return r => {
                    if (!r.value || r.modifier) return;
                    let n;
                    if ("arbitrary" === r.value.kind) {
                        n = r.value.value;
                        let e = r.value.dataType ?? H(n, ["angle", "vector"]);
                        if ("vector" === e) return [y("rotate", `${n} var(--tw-rotate)`)];
                        if ("angle" !== e) return [y("rotate", n)]
                    } else if (n = e.resolve(r.value.value, ["--rotate"]), !n && ae(r.value.value) && (n = `${r.value.value}deg`), !n) return;
                    return [y("rotate", t ? `calc(${n} * -1)` : n)]
                }
            }

            n("scale-3d", [c, ["scale", "var(--tw-scale-x) var(--tw-scale-y) var(--tw-scale-z)"]]), n("rotate-none", [["rotate", "none"]]), t.functional("-rotate", d({negative: !0})), t.functional("rotate", d({negative: !1})), r("rotate", (() => [{
                supportsNegative: !0,
                values: ["0", "1", "2", "3", "6", "12", "45", "90", "180"],
                valueThemeKeys: ["--rotate"]
            }]));
            {
                let e = ["var(--tw-rotate-x)", "var(--tw-rotate-y)", "var(--tw-rotate-z)", "var(--tw-skew-x)", "var(--tw-skew-y)"].join(" "),
                    i = () => A([be("--tw-rotate-x", "rotateX(0)"), be("--tw-rotate-y", "rotateY(0)"), be("--tw-rotate-z", "rotateZ(0)"), be("--tw-skew-x", "skewX(0)"), be("--tw-skew-y", "skewY(0)")]);
                for (let t of ["x", "y", "z"]) o(`rotate-${t}`, {
                    supportsNegative: !0,
                    themeKeys: ["--rotate"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}deg` : null,
                    handle: r => [i(), y(`--tw-rotate-${t}`, `rotate${t.toUpperCase()}(${r})`), y("transform", e)]
                }), r(`rotate-${t}`, (() => [{
                    supportsNegative: !0,
                    values: ["0", "1", "2", "3", "6", "12", "45", "90", "180"],
                    valueThemeKeys: ["--rotate"]
                }]));
                o("skew", {
                    supportsNegative: !0,
                    themeKeys: ["--skew"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}deg` : null,
                    handle: t => [i(), y("--tw-skew-x", `skewX(${t})`), y("--tw-skew-y", `skewY(${t})`), y("transform", e)]
                }), o("skew-x", {
                    supportsNegative: !0,
                    themeKeys: ["--skew"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}deg` : null,
                    handle: t => [i(), y("--tw-skew-x", `skewX(${t})`), y("transform", e)]
                }), o("skew-y", {
                    supportsNegative: !0,
                    themeKeys: ["--skew"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}deg` : null,
                    handle: t => [i(), y("--tw-skew-y", `skewY(${t})`), y("transform", e)]
                }), r("skew", (() => [{
                    supportsNegative: !0,
                    values: ["0", "1", "2", "3", "6", "12"],
                    valueThemeKeys: ["--skew"]
                }])), r("skew-x", (() => [{
                    supportsNegative: !0,
                    values: ["0", "1", "2", "3", "6", "12"],
                    valueThemeKeys: ["--skew"]
                }])), r("skew-y", (() => [{
                    supportsNegative: !0,
                    values: ["0", "1", "2", "3", "6", "12"],
                    valueThemeKeys: ["--skew"]
                }])), t.functional("transform", (t => {
                    if (t.modifier) return;
                    let r = null;
                    return t.value ? "arbitrary" === t.value.kind && (r = t.value.value) : r = e, null !== r ? [i(), y("transform", r)] : void 0
                })), r("transform", (() => [{hasDefaultValue: !0}])), n("transform-cpu", [["transform", e]]), n("transform-gpu", [["transform", `translateZ(0) ${e}`]]), n("transform-none", [["transform", "none"]])
            }
            n("transform-flat", [["transform-style", "flat"]]), n("transform-3d", [["transform-style", "preserve-3d"]]), n("transform-content", [["transform-box", "content-box"]]), n("transform-border", [["transform-box", "border-box"]]), n("transform-fill", [["transform-box", "fill-box"]]), n("transform-stroke", [["transform-box", "stroke-box"]]), n("transform-view", [["transform-box", "view-box"]]), n("backface-visible", [["backface-visibility", "visible"]]), n("backface-hidden", [["backface-visibility", "hidden"]]);
            for (let e of ["auto", "default", "pointer", "wait", "text", "move", "help", "not-allowed", "none", "context-menu", "progress", "cell", "crosshair", "vertical-text", "alias", "copy", "no-drop", "grab", "grabbing", "all-scroll", "col-resize", "row-resize", "n-resize", "e-resize", "s-resize", "w-resize", "ne-resize", "nw-resize", "se-resize", "sw-resize", "ew-resize", "ns-resize", "nesw-resize", "nwse-resize", "zoom-in", "zoom-out"]) n(`cursor-${e}`, [["cursor", e]]);
            o("cursor", {themeKeys: ["--cursor"], handle: e => [y("cursor", e)]});
            for (let e of ["auto", "none", "manipulation"]) n(`touch-${e}`, [["touch-action", e]]);
            let f = () => A([be("--tw-pan-x"), be("--tw-pan-y"), be("--tw-pinch-zoom")]);
            for (let e of ["x", "left", "right"]) n(`touch-pan-${e}`, [f, ["--tw-pan-x", `pan-${e}`], ["touch-action", "var(--tw-pan-x,) var(--tw-pan-y,) var(--tw-pinch-zoom,)"]]);
            for (let e of ["y", "up", "down"]) n(`touch-pan-${e}`, [f, ["--tw-pan-y", `pan-${e}`], ["touch-action", "var(--tw-pan-x,) var(--tw-pan-y,) var(--tw-pinch-zoom,)"]]);
            n("touch-pinch-zoom", [f, ["--tw-pinch-zoom", "pinch-zoom"], ["touch-action", "var(--tw-pan-x,) var(--tw-pan-y,) var(--tw-pinch-zoom,)"]]);
            for (let e of ["none", "text", "all", "auto"]) n(`select-${e}`, [["-webkit-user-select", e], ["user-select", e]]);
            n("resize-none", [["resize", "none"]]), n("resize-x", [["resize", "horizontal"]]), n("resize-y", [["resize", "vertical"]]), n("resize", [["resize", "both"]]), n("snap-none", [["scroll-snap-type", "none"]]);
            let h = () => A([be("--tw-scroll-snap-strictness", "proximity", "*")]);
            for (let e of ["x", "y", "both"]) n(`snap-${e}`, [h, ["scroll-snap-type", `${e} var(--tw-scroll-snap-strictness)`]]);
            n("snap-mandatory", [h, ["--tw-scroll-snap-strictness", "mandatory"]]), n("snap-proximity", [h, ["--tw-scroll-snap-strictness", "proximity"]]), n("snap-align-none", [["scroll-snap-align", "none"]]), n("snap-start", [["scroll-snap-align", "start"]]), n("snap-end", [["scroll-snap-align", "end"]]), n("snap-center", [["scroll-snap-align", "center"]]), n("snap-normal", [["scroll-snap-stop", "normal"]]), n("snap-always", [["scroll-snap-stop", "always"]]);
            for (let [e, t] of [["scroll-m", "scroll-margin"], ["scroll-mx", "scroll-margin-inline"], ["scroll-my", "scroll-margin-block"], ["scroll-ms", "scroll-margin-inline-start"], ["scroll-me", "scroll-margin-inline-end"], ["scroll-mt", "scroll-margin-top"], ["scroll-mr", "scroll-margin-right"], ["scroll-mb", "scroll-margin-bottom"], ["scroll-ml", "scroll-margin-left"]]) l(e, ["--scroll-margin", "--spacing"], (e => [y(t, e)]), {supportsNegative: !0});
            for (let [e, t] of [["scroll-p", "scroll-padding"], ["scroll-px", "scroll-padding-inline"], ["scroll-py", "scroll-padding-block"], ["scroll-ps", "scroll-padding-inline-start"], ["scroll-pe", "scroll-padding-inline-end"], ["scroll-pt", "scroll-padding-top"], ["scroll-pr", "scroll-padding-right"], ["scroll-pb", "scroll-padding-bottom"], ["scroll-pl", "scroll-padding-left"]]) l(e, ["--scroll-padding", "--spacing"], (e => [y(t, e)]));
            n("list-inside", [["list-style-position", "inside"]]), n("list-outside", [["list-style-position", "outside"]]), n("list-none", [["list-style-type", "none"]]), n("list-disc", [["list-style-type", "disc"]]), n("list-decimal", [["list-style-type", "decimal"]]), o("list", {
                themeKeys: ["--list-style-type"],
                handle: e => [y("list-style-type", e)]
            }), n("list-image-none", [["list-style-image", "none"]]), o("list-image", {
                themeKeys: ["--list-style-image"],
                handle: e => [y("list-style-image", e)]
            }), n("appearance-none", [["appearance", "none"]]), n("appearance-auto", [["appearance", "auto"]]), n("scheme-normal", [["color-scheme", "normal"]]), n("scheme-dark", [["color-scheme", "dark"]]), n("scheme-light", [["color-scheme", "light"]]), n("scheme-light-dark", [["color-scheme", "light dark"]]), n("scheme-only-dark", [["color-scheme", "only dark"]]), n("scheme-only-light", [["color-scheme", "only light"]]), n("columns-auto", [["columns", "auto"]]), o("columns", {
                themeKeys: ["--columns", "--container"],
                handleBareValue: ({value: e}) => ae(e) ? e : null,
                handle: e => [y("columns", e)]
            }), r("columns", (() => [{
                values: Array.from({length: 12}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--columns", "--container"]
            }]));
            for (let e of ["auto", "avoid", "all", "avoid-page", "page", "left", "right", "column"]) n(`break-before-${e}`, [["break-before", e]]);
            for (let e of ["auto", "avoid", "avoid-page", "avoid-column"]) n(`break-inside-${e}`, [["break-inside", e]]);
            for (let e of ["auto", "avoid", "all", "avoid-page", "page", "left", "right", "column"]) n(`break-after-${e}`, [["break-after", e]]);
            n("grid-flow-row", [["grid-auto-flow", "row"]]), n("grid-flow-col", [["grid-auto-flow", "column"]]), n("grid-flow-dense", [["grid-auto-flow", "dense"]]), n("grid-flow-row-dense", [["grid-auto-flow", "row dense"]]), n("grid-flow-col-dense", [["grid-auto-flow", "column dense"]]), n("auto-cols-auto", [["grid-auto-columns", "auto"]]), n("auto-cols-min", [["grid-auto-columns", "min-content"]]), n("auto-cols-max", [["grid-auto-columns", "max-content"]]), n("auto-cols-fr", [["grid-auto-columns", "minmax(0, 1fr)"]]), o("auto-cols", {
                themeKeys: ["--grid-auto-columns"],
                handle: e => [y("grid-auto-columns", e)]
            }), n("auto-rows-auto", [["grid-auto-rows", "auto"]]), n("auto-rows-min", [["grid-auto-rows", "min-content"]]), n("auto-rows-max", [["grid-auto-rows", "max-content"]]), n("auto-rows-fr", [["grid-auto-rows", "minmax(0, 1fr)"]]), o("auto-rows", {
                themeKeys: ["--grid-auto-rows"],
                handle: e => [y("grid-auto-rows", e)]
            }), n("grid-cols-none", [["grid-template-columns", "none"]]), n("grid-cols-subgrid", [["grid-template-columns", "subgrid"]]), o("grid-cols", {
                themeKeys: ["--grid-template-columns"],
                handleBareValue: ({value: e}) => se(e) ? `repeat(${e}, minmax(0, 1fr))` : null,
                handle: e => [y("grid-template-columns", e)]
            }), n("grid-rows-none", [["grid-template-rows", "none"]]), n("grid-rows-subgrid", [["grid-template-rows", "subgrid"]]), o("grid-rows", {
                themeKeys: ["--grid-template-rows"],
                handleBareValue: ({value: e}) => se(e) ? `repeat(${e}, minmax(0, 1fr))` : null,
                handle: e => [y("grid-template-rows", e)]
            }), r("grid-cols", (() => [{
                values: Array.from({length: 12}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--grid-template-columns"]
            }])), r("grid-rows", (() => [{
                values: Array.from({length: 12}, ((e, t) => `${t + 1}`)),
                valueThemeKeys: ["--grid-template-rows"]
            }])), n("flex-row", [["flex-direction", "row"]]), n("flex-row-reverse", [["flex-direction", "row-reverse"]]), n("flex-col", [["flex-direction", "column"]]), n("flex-col-reverse", [["flex-direction", "column-reverse"]]), n("flex-wrap", [["flex-wrap", "wrap"]]), n("flex-nowrap", [["flex-wrap", "nowrap"]]), n("flex-wrap-reverse", [["flex-wrap", "wrap-reverse"]]), n("place-content-center", [["place-content", "center"]]), n("place-content-start", [["place-content", "start"]]), n("place-content-end", [["place-content", "end"]]), n("place-content-between", [["place-content", "space-between"]]), n("place-content-around", [["place-content", "space-around"]]), n("place-content-evenly", [["place-content", "space-evenly"]]), n("place-content-baseline", [["place-content", "baseline"]]), n("place-content-stretch", [["place-content", "stretch"]]), n("place-items-center", [["place-items", "center"]]), n("place-items-start", [["place-items", "start"]]), n("place-items-end", [["place-items", "end"]]), n("place-items-baseline", [["place-items", "baseline"]]), n("place-items-stretch", [["place-items", "stretch"]]), n("content-normal", [["align-content", "normal"]]), n("content-center", [["align-content", "center"]]), n("content-start", [["align-content", "flex-start"]]), n("content-end", [["align-content", "flex-end"]]), n("content-between", [["align-content", "space-between"]]), n("content-around", [["align-content", "space-around"]]), n("content-evenly", [["align-content", "space-evenly"]]), n("content-baseline", [["align-content", "baseline"]]), n("content-stretch", [["align-content", "stretch"]]), n("items-center", [["align-items", "center"]]), n("items-start", [["align-items", "flex-start"]]), n("items-end", [["align-items", "flex-end"]]), n("items-baseline", [["align-items", "baseline"]]), n("items-stretch", [["align-items", "stretch"]]), n("justify-normal", [["justify-content", "normal"]]), n("justify-center", [["justify-content", "center"]]), n("justify-start", [["justify-content", "flex-start"]]), n("justify-end", [["justify-content", "flex-end"]]), n("justify-between", [["justify-content", "space-between"]]), n("justify-around", [["justify-content", "space-around"]]), n("justify-evenly", [["justify-content", "space-evenly"]]), n("justify-baseline", [["justify-content", "baseline"]]), n("justify-stretch", [["justify-content", "stretch"]]), n("justify-items-normal", [["justify-items", "normal"]]), n("justify-items-center", [["justify-items", "center"]]), n("justify-items-start", [["justify-items", "start"]]), n("justify-items-end", [["justify-items", "end"]]), n("justify-items-stretch", [["justify-items", "stretch"]]), l("gap", ["--gap", "--spacing"], (e => [y("gap", e)])), l("gap-x", ["--gap", "--spacing"], (e => [y("column-gap", e)])), l("gap-y", ["--gap", "--spacing"], (e => [y("row-gap", e)])), l("space-x", ["--space", "--spacing"], (e => [A([be("--tw-space-x-reverse", "0")]), b(":where(& > :not(:last-child))", [y("--tw-sort", "row-gap"), y("--tw-space-x-reverse", "0"), y("margin-inline-start", `calc(${e} * var(--tw-space-x-reverse))`), y("margin-inline-end", `calc(${e} * calc(1 - var(--tw-space-x-reverse)))`)])]), {supportsNegative: !0}), l("space-y", ["--space", "--spacing"], (e => [A([be("--tw-space-y-reverse", "0")]), b(":where(& > :not(:last-child))", [y("--tw-sort", "column-gap"), y("--tw-space-y-reverse", "0"), y("margin-block-start", `calc(${e} * var(--tw-space-y-reverse))`), y("margin-block-end", `calc(${e} * calc(1 - var(--tw-space-y-reverse)))`)])]), {supportsNegative: !0}), n("space-x-reverse", [() => A([be("--tw-space-x-reverse", "0")]), () => b(":where(& > :not(:last-child))", [y("--tw-sort", "row-gap"), y("--tw-space-x-reverse", "1")])]), n("space-y-reverse", [() => A([be("--tw-space-y-reverse", "0")]), () => b(":where(& > :not(:last-child))", [y("--tw-sort", "column-gap"), y("--tw-space-y-reverse", "1")])]), n("accent-auto", [["accent-color", "auto"]]), i("accent", {
                themeKeys: ["--accent-color", "--color"],
                handle: e => [y("accent-color", e)]
            }), i("caret", {
                themeKeys: ["--caret-color", "--color"],
                handle: e => [y("caret-color", e)]
            }), i("divide", {
                themeKeys: ["--divide-color", "--color"],
                handle: e => [b(":where(& > :not(:last-child))", [y("--tw-sort", "divide-color"), y("border-color", e)])]
            }), n("place-self-auto", [["place-self", "auto"]]), n("place-self-start", [["place-self", "start"]]), n("place-self-end", [["place-self", "end"]]), n("place-self-center", [["place-self", "center"]]), n("place-self-stretch", [["place-self", "stretch"]]), n("self-auto", [["align-self", "auto"]]), n("self-start", [["align-self", "flex-start"]]), n("self-end", [["align-self", "flex-end"]]), n("self-center", [["align-self", "center"]]), n("self-stretch", [["align-self", "stretch"]]), n("self-baseline", [["align-self", "baseline"]]), n("justify-self-auto", [["justify-self", "auto"]]), n("justify-self-start", [["justify-self", "flex-start"]]), n("justify-self-end", [["justify-self", "flex-end"]]), n("justify-self-center", [["justify-self", "center"]]), n("justify-self-stretch", [["justify-self", "stretch"]]);
            for (let e of ["auto", "hidden", "clip", "visible", "scroll"]) n(`overflow-${e}`, [["overflow", e]]), n(`overflow-x-${e}`, [["overflow-x", e]]), n(`overflow-y-${e}`, [["overflow-y", e]]);
            for (let e of ["auto", "contain", "none"]) n(`overscroll-${e}`, [["overscroll-behavior", e]]), n(`overscroll-x-${e}`, [["overscroll-behavior-x", e]]), n(`overscroll-y-${e}`, [["overscroll-behavior-y", e]]);
            n("scroll-auto", [["scroll-behavior", "auto"]]), n("scroll-smooth", [["scroll-behavior", "smooth"]]), n("truncate", [["overflow", "hidden"], ["text-overflow", "ellipsis"], ["white-space", "nowrap"]]), n("text-ellipsis", [["text-overflow", "ellipsis"]]), n("text-clip", [["text-overflow", "clip"]]), n("hyphens-none", [["-webkit-hyphens", "none"], ["hyphens", "none"]]), n("hyphens-manual", [["-webkit-hyphens", "manual"], ["hyphens", "manual"]]), n("hyphens-auto", [["-webkit-hyphens", "auto"], ["hyphens", "auto"]]), n("whitespace-normal", [["white-space", "normal"]]), n("whitespace-nowrap", [["white-space", "nowrap"]]), n("whitespace-pre", [["white-space", "pre"]]), n("whitespace-pre-line", [["white-space", "pre-line"]]), n("whitespace-pre-wrap", [["white-space", "pre-wrap"]]), n("whitespace-break-spaces", [["white-space", "break-spaces"]]), n("text-wrap", [["text-wrap", "wrap"]]), n("text-nowrap", [["text-wrap", "nowrap"]]), n("text-balance", [["text-wrap", "balance"]]), n("text-pretty", [["text-wrap", "pretty"]]), n("break-normal", [["overflow-wrap", "normal"], ["word-break", "normal"]]), n("break-words", [["overflow-wrap", "break-word"]]), n("break-all", [["word-break", "break-all"]]), n("break-keep", [["word-break", "keep-all"]]);
            for (let [e, t] of [["rounded", ["border-radius"]], ["rounded-s", ["border-start-start-radius", "border-end-start-radius"]], ["rounded-e", ["border-start-end-radius", "border-end-end-radius"]], ["rounded-t", ["border-top-left-radius", "border-top-right-radius"]], ["rounded-r", ["border-top-right-radius", "border-bottom-right-radius"]], ["rounded-b", ["border-bottom-right-radius", "border-bottom-left-radius"]], ["rounded-l", ["border-top-left-radius", "border-bottom-left-radius"]], ["rounded-ss", ["border-start-start-radius"]], ["rounded-se", ["border-start-end-radius"]], ["rounded-ee", ["border-end-end-radius"]], ["rounded-es", ["border-end-start-radius"]], ["rounded-tl", ["border-top-left-radius"]], ["rounded-tr", ["border-top-right-radius"]], ["rounded-br", ["border-bottom-right-radius"]], ["rounded-bl", ["border-bottom-left-radius"]]]) n(`${e}-none`, t.map((e => [e, "0"]))), n(`${e}-full`, t.map((e => [e, "calc(infinity * 1px)"]))), o(e, {
                themeKeys: ["--radius"],
                handle: e => t.map((t => y(t, e)))
            });
            n("border-solid", [["--tw-border-style", "solid"], ["border-style", "solid"]]), n("border-dashed", [["--tw-border-style", "dashed"], ["border-style", "dashed"]]), n("border-dotted", [["--tw-border-style", "dotted"], ["border-style", "dotted"]]), n("border-double", [["--tw-border-style", "double"], ["border-style", "double"]]), n("border-hidden", [["--tw-border-style", "hidden"], ["border-style", "hidden"]]), n("border-none", [["--tw-border-style", "none"], ["border-style", "none"]]);
            {
                let i = function (n, o) {
                    t.functional(n, (t => {
                        if (!t.value) {
                            if (t.modifier) return;
                            let r = e.get(["--default-border-width"]) ?? "1px", n = o.width(r);
                            return n ? [l(), ...n] : void 0
                        }
                        if ("arbitrary" === t.value.kind) {
                            let r = t.value.value;
                            switch (t.value.dataType ?? H(r, ["color", "line-width", "length"])) {
                                case"line-width":
                                case"length": {
                                    if (t.modifier) return;
                                    let e = o.width(r);
                                    return e ? [l(), ...e] : void 0
                                }
                                default:
                                    return r = ke(r, t.modifier, e), null === r ? void 0 : o.color(r)
                            }
                        }
                        {
                            let r = ye(t, e, ["--border-color", "--color"]);
                            if (r) return o.color(r)
                        }
                        {
                            if (t.modifier) return;
                            let r = e.resolve(t.value.value, ["--border-width"]);
                            if (r) {
                                let e = o.width(r);
                                return e ? [l(), ...e] : void 0
                            }
                            if (ae(t.value.value)) {
                                let e = o.width(`${t.value.value}px`);
                                return e ? [l(), ...e] : void 0
                            }
                        }
                    })), r(n, (() => [{
                        values: ["current", "inherit", "transparent"],
                        valueThemeKeys: ["--border-color", "--color"],
                        modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t)),
                        hasDefaultValue: !0
                    }, {values: ["0", "2", "4", "8"], valueThemeKeys: ["--border-width"]}]))
                }, l = () => A([be("--tw-border-style", "solid")]);
                i("border", {
                    width: e => [y("border-style", "var(--tw-border-style)"), y("border-width", e)],
                    color: e => [y("border-color", e)]
                }), i("border-x", {
                    width: e => [y("border-inline-style", "var(--tw-border-style)"), y("border-inline-width", e)],
                    color: e => [y("border-inline-color", e)]
                }), i("border-y", {
                    width: e => [y("border-block-style", "var(--tw-border-style)"), y("border-block-width", e)],
                    color: e => [y("border-block-color", e)]
                }), i("border-s", {
                    width: e => [y("border-inline-start-style", "var(--tw-border-style)"), y("border-inline-start-width", e)],
                    color: e => [y("border-inline-start-color", e)]
                }), i("border-e", {
                    width: e => [y("border-inline-end-style", "var(--tw-border-style)"), y("border-inline-end-width", e)],
                    color: e => [y("border-inline-end-color", e)]
                }), i("border-t", {
                    width: e => [y("border-top-style", "var(--tw-border-style)"), y("border-top-width", e)],
                    color: e => [y("border-top-color", e)]
                }), i("border-r", {
                    width: e => [y("border-right-style", "var(--tw-border-style)"), y("border-right-width", e)],
                    color: e => [y("border-right-color", e)]
                }), i("border-b", {
                    width: e => [y("border-bottom-style", "var(--tw-border-style)"), y("border-bottom-width", e)],
                    color: e => [y("border-bottom-color", e)]
                }), i("border-l", {
                    width: e => [y("border-left-style", "var(--tw-border-style)"), y("border-left-width", e)],
                    color: e => [y("border-left-color", e)]
                }), o("divide-x", {
                    defaultValue: e.get(["--default-border-width"]) ?? "1px",
                    themeKeys: ["--divide-width", "--border-width"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}px` : null,
                    handle: e => [A([be("--tw-divide-x-reverse", "0")]), b(":where(& > :not(:last-child))", [y("--tw-sort", "divide-x-width"), l(), y("--tw-divide-x-reverse", "0"), y("border-inline-style", "var(--tw-border-style)"), y("border-inline-start-width", `calc(${e} * var(--tw-divide-x-reverse))`), y("border-inline-end-width", `calc(${e} * calc(1 - var(--tw-divide-x-reverse)))`)])]
                }), o("divide-y", {
                    defaultValue: e.get(["--default-border-width"]) ?? "1px",
                    themeKeys: ["--divide-width", "--border-width"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}px` : null,
                    handle: e => [A([be("--tw-divide-y-reverse", "0")]), b(":where(& > :not(:last-child))", [y("--tw-sort", "divide-y-width"), l(), y("--tw-divide-y-reverse", "0"), y("border-bottom-style", "var(--tw-border-style)"), y("border-top-style", "var(--tw-border-style)"), y("border-top-width", `calc(${e} * var(--tw-divide-y-reverse))`), y("border-bottom-width", `calc(${e} * calc(1 - var(--tw-divide-y-reverse)))`)])]
                }), r("divide-x", (() => [{
                    values: ["0", "2", "4", "8"],
                    valueThemeKeys: ["--divide-width", "--border-width"],
                    hasDefaultValue: !0
                }])), r("divide-y", (() => [{
                    values: ["0", "2", "4", "8"],
                    valueThemeKeys: ["--divide-width", "--border-width"],
                    hasDefaultValue: !0
                }])), n("divide-x-reverse", [() => A([be("--tw-divide-x-reverse", "0")]), () => b(":where(& > :not(:last-child))", [y("--tw-divide-x-reverse", "1")])]), n("divide-y-reverse", [() => A([be("--tw-divide-y-reverse", "0")]), () => b(":where(& > :not(:last-child))", [y("--tw-divide-y-reverse", "1")])]);
                for (let e of ["solid", "dashed", "dotted", "double", "none"]) n(`divide-${e}`, [() => b(":where(& > :not(:last-child))", [y("--tw-sort", "divide-style"), y("--tw-border-style", e), y("border-style", e)])])
            }
            n("bg-auto", [["background-size", "auto"]]), n("bg-cover", [["background-size", "cover"]]), n("bg-contain", [["background-size", "contain"]]), n("bg-fixed", [["background-attachment", "fixed"]]), n("bg-local", [["background-attachment", "local"]]), n("bg-scroll", [["background-attachment", "scroll"]]), n("bg-center", [["background-position", "center"]]), n("bg-top", [["background-position", "top"]]), n("bg-right-top", [["background-position", "right top"]]), n("bg-right", [["background-position", "right"]]), n("bg-right-bottom", [["background-position", "right bottom"]]), n("bg-bottom", [["background-position", "bottom"]]), n("bg-left-bottom", [["background-position", "left bottom"]]), n("bg-left", [["background-position", "left"]]), n("bg-left-top", [["background-position", "left top"]]), n("bg-repeat", [["background-repeat", "repeat"]]), n("bg-no-repeat", [["background-repeat", "no-repeat"]]), n("bg-repeat-x", [["background-repeat", "repeat-x"]]), n("bg-repeat-y", [["background-repeat", "repeat-y"]]), n("bg-repeat-round", [["background-repeat", "round"]]), n("bg-repeat-space", [["background-repeat", "space"]]), n("bg-none", [["background-image", "none"]]);
            {
                let e = function (e) {
                        let t = "in oklab";
                        if ("named" === e?.kind) switch (e.value) {
                            case"longer":
                            case"shorter":
                            case"increasing":
                            case"decreasing":
                                t = `in oklch ${e.value} hue`;
                                break;
                            default:
                                t = `in ${e.value}`
                        } else "arbitrary" === e?.kind && (t = e.value);
                        return t
                    }, n = function ({negative: t}) {
                        return r => {
                            if (!r.value) return;
                            if ("arbitrary" === r.value.kind) {
                                if (r.modifier) return;
                                let e = r.value.value;
                                return "angle" === (r.value.dataType ?? H(e, ["angle"])) ? (e = t ? `calc(${e} * -1)` : `${e}`, [y("--tw-gradient-position", e), y("background-image", `linear-gradient(var(--tw-gradient-stops,${e}))`)]) : t ? void 0 : [y("--tw-gradient-position", e), y("background-image", `linear-gradient(var(--tw-gradient-stops,${e}))`)]
                            }
                            let n = r.value.value;
                            if (!t && l.has(n)) n = l.get(n); else {
                                if (!ae(n)) return;
                                n = t ? `calc(${n}deg * -1)` : `${n}deg`
                            }
                            return [y("--tw-gradient-position", `${n} ${e(r.modifier)}`), y("background-image", "linear-gradient(var(--tw-gradient-stops))")]
                        }
                    }, o = function ({negative: t}) {
                        return r => {
                            if ("arbitrary" === r.value?.kind) {
                                if (r.modifier) return;
                                let e = r.value.value;
                                return [y("--tw-gradient-position", e), y("background-image", `conic-gradient(var(--tw-gradient-stops,${e}))`)]
                            }
                            let n = e(r.modifier);
                            if (!r.value) return [y("--tw-gradient-position", n), y("background-image", "conic-gradient(var(--tw-gradient-stops))")];
                            let o = r.value.value;
                            return ae(o) ? (o = t ? `calc(${o} * -1)` : `${o}deg`, [y("--tw-gradient-position", `from ${o} ${n}`), y("background-image", "conic-gradient(var(--tw-gradient-stops))")]) : void 0
                        }
                    }, i = ["oklab", "oklch", "srgb", "hsl", "longer", "shorter", "increasing", "decreasing"],
                    l = new Map([["to-t", "to top"], ["to-tr", "to top right"], ["to-r", "to right"], ["to-br", "to bottom right"], ["to-b", "to bottom"], ["to-bl", "to bottom left"], ["to-l", "to left"], ["to-tl", "to top left"]]);
                t.functional("-bg-linear", n({negative: !0})), t.functional("bg-linear", n({negative: !1})), r("bg-linear", (() => [{
                    values: [...l.keys()],
                    modifiers: i
                }, {
                    values: ["0", "30", "60", "90", "120", "150", "180", "210", "240", "270", "300", "330"],
                    supportsNegative: !0,
                    modifiers: i
                }])), t.functional("-bg-conic", o({negative: !0})), t.functional("bg-conic", o({negative: !1})), r("bg-conic", (() => [{
                    hasDefaultValue: !0,
                    modifiers: i
                }, {
                    values: ["0", "30", "60", "90", "120", "150", "180", "210", "240", "270", "300", "330"],
                    supportsNegative: !0,
                    modifiers: i
                }])), t.functional("bg-radial", (t => {
                    if (!t.value) return [y("--tw-gradient-position", e(t.modifier)), y("background-image", "radial-gradient(var(--tw-gradient-stops))")];
                    if ("arbitrary" === t.value.kind) {
                        if (t.modifier) return;
                        let e = t.value.value;
                        return [y("--tw-gradient-position", e), y("background-image", `radial-gradient(var(--tw-gradient-stops,${e}))`)]
                    }
                })), r("bg-radial", (() => [{hasDefaultValue: !0, modifiers: i}]))
            }
            t.functional("bg", (t => {
                if (t.value) {
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        switch (t.value.dataType ?? H(r, ["image", "color", "percentage", "position", "bg-size", "length", "url"])) {
                            case"percentage":
                            case"position":
                                return t.modifier ? void 0 : [y("background-position", r)];
                            case"bg-size":
                            case"length":
                            case"size":
                                return t.modifier ? void 0 : [y("background-size", r)];
                            case"image":
                            case"url":
                                return t.modifier ? void 0 : [y("background-image", r)];
                            default:
                                return r = ke(r, t.modifier, e), null === r ? void 0 : [y("background-color", r)]
                        }
                    }
                    {
                        let r = ye(t, e, ["--background-color", "--color"]);
                        if (r) return [y("background-color", r)]
                    }
                    {
                        if (t.modifier) return;
                        let r = e.resolve(t.value.value, ["--background-image"]);
                        if (r) return [y("background-image", r)]
                    }
                }
            })), r("bg", (() => [{
                values: ["current", "inherit", "transparent"],
                valueThemeKeys: ["--background-color", "--color"],
                modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
            }, {values: [], valueThemeKeys: ["--background-image"]}]));
            let p = () => A([be("--tw-gradient-position"), be("--tw-gradient-from", "#0000", "<color>"), be("--tw-gradient-via", "#0000", "<color>"), be("--tw-gradient-to", "#0000", "<color>"), be("--tw-gradient-stops"), be("--tw-gradient-via-stops"), be("--tw-gradient-from-position", "0%", "<length-percentage>"), be("--tw-gradient-via-position", "50%", "<length-percentage>"), be("--tw-gradient-to-position", "100%", "<length-percentage>")]);

            function m(n, o) {
                t.functional(n, (t => {
                    if (t.value) {
                        if ("arbitrary" === t.value.kind) {
                            let r = t.value.value;
                            switch (t.value.dataType ?? H(r, ["color", "length", "percentage"])) {
                                case"length":
                                case"percentage":
                                    return t.modifier ? void 0 : o.position(r);
                                default:
                                    return r = ke(r, t.modifier, e), null === r ? void 0 : o.color(r)
                            }
                        }
                        {
                            let r = ye(t, e, ["--background-color", "--color"]);
                            if (r) return o.color(r)
                        }
                        {
                            if (t.modifier) return;
                            let r = e.resolve(t.value.value, ["--gradient-color-stop-positions"]);
                            if (r) return o.position(r);
                            if ("%" === t.value.value[t.value.value.length - 1] && ae(t.value.value.slice(0, -1))) return o.position(t.value.value)
                        }
                    }
                })), r(n, (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: ["--background-color", "--color"],
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
                }, {
                    values: Array.from({length: 21}, ((e, t) => 5 * t + "%")),
                    valueThemeKeys: ["--gradient-color-stop-positions"]
                }]))
            }

            m("from", {
                color: e => [p(), y("--tw-sort", "--tw-gradient-from"), y("--tw-gradient-from", e), y("--tw-gradient-stops", "var(--tw-gradient-via-stops, var(--tw-gradient-position), var(--tw-gradient-from) var(--tw-gradient-from-position), var(--tw-gradient-to) var(--tw-gradient-to-position))")],
                position: e => [p(), y("--tw-gradient-from-position", e)]
            }), n("via-none", [["--tw-gradient-via-stops", "initial"]]), m("via", {
                color: e => [p(), y("--tw-sort", "--tw-gradient-via"), y("--tw-gradient-via", e), y("--tw-gradient-via-stops", "var(--tw-gradient-position), var(--tw-gradient-from) var(--tw-gradient-from-position), var(--tw-gradient-via) var(--tw-gradient-via-position), var(--tw-gradient-to) var(--tw-gradient-to-position)"), y("--tw-gradient-stops", "var(--tw-gradient-via-stops)")],
                position: e => [p(), y("--tw-gradient-via-position", e)]
            }), m("to", {
                color: e => [p(), y("--tw-sort", "--tw-gradient-to"), y("--tw-gradient-to", e), y("--tw-gradient-stops", "var(--tw-gradient-via-stops, var(--tw-gradient-position), var(--tw-gradient-from) var(--tw-gradient-from-position), var(--tw-gradient-to) var(--tw-gradient-to-position))")],
                position: e => [p(), y("--tw-gradient-to-position", e)]
            }), n("box-decoration-slice", [["-webkit-box-decoration-break", "slice"], ["box-decoration-break", "slice"]]), n("box-decoration-clone", [["-webkit-box-decoration-break", "clone"], ["box-decoration-break", "clone"]]), n("bg-clip-text", [["background-clip", "text"]]), n("bg-clip-border", [["background-clip", "border-box"]]), n("bg-clip-padding", [["background-clip", "padding-box"]]), n("bg-clip-content", [["background-clip", "content-box"]]), n("bg-origin-border", [["background-origin", "border-box"]]), n("bg-origin-padding", [["background-origin", "padding-box"]]), n("bg-origin-content", [["background-origin", "content-box"]]);
            for (let e of ["normal", "multiply", "screen", "overlay", "darken", "lighten", "color-dodge", "color-burn", "hard-light", "soft-light", "difference", "exclusion", "hue", "saturation", "color", "luminosity"]) n(`bg-blend-${e}`, [["background-blend-mode", e]]), n(`mix-blend-${e}`, [["mix-blend-mode", e]]);
            n("mix-blend-plus-darker", [["mix-blend-mode", "plus-darker"]]), n("mix-blend-plus-lighter", [["mix-blend-mode", "plus-lighter"]]), n("fill-none", [["fill", "none"]]), t.functional("fill", (t => {
                if (!t.value) return;
                if ("arbitrary" === t.value.kind) {
                    let r = ke(t.value.value, t.modifier, e);
                    return null === r ? void 0 : [y("fill", r)]
                }
                let r = ye(t, e, ["--fill", "--color"]);
                return r ? [y("fill", r)] : void 0
            })), r("fill", (() => [{
                values: ["current", "inherit", "transparent"],
                valueThemeKeys: ["--fill", "--color"],
                modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
            }])), n("stroke-none", [["stroke", "none"]]), t.functional("stroke", (t => {
                if (t.value) {
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        switch (t.value.dataType ?? H(r, ["color", "number", "length", "percentage"])) {
                            case"number":
                            case"length":
                            case"percentage":
                                return t.modifier ? void 0 : [y("stroke-width", r)];
                            default:
                                return r = ke(t.value.value, t.modifier, e), null === r ? void 0 : [y("stroke", r)]
                        }
                    }
                    {
                        let r = ye(t, e, ["--stroke", "--color"]);
                        if (r) return [y("stroke", r)]
                    }
                    {
                        let r = e.resolve(t.value.value, ["--stroke-width"]);
                        if (r) return [y("stroke-width", r)];
                        if (ae(t.value.value)) return [y("stroke-width", t.value.value)]
                    }
                }
            })), r("stroke", (() => [{
                values: ["current", "inherit", "transparent"],
                valueThemeKeys: ["--stroke", "--color"],
                modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
            }, {
                values: ["0", "1", "2", "3"],
                valueThemeKeys: ["--stroke-width"]
            }])), n("object-contain", [["object-fit", "contain"]]), n("object-cover", [["object-fit", "cover"]]), n("object-fill", [["object-fit", "fill"]]), n("object-none", [["object-fit", "none"]]), n("object-scale-down", [["object-fit", "scale-down"]]), n("object-bottom", [["object-position", "bottom"]]), n("object-center", [["object-position", "center"]]), n("object-left", [["object-position", "left"]]), n("object-left-bottom", [["object-position", "left bottom"]]), n("object-left-top", [["object-position", "left top"]]), n("object-right", [["object-position", "right"]]), n("object-right-bottom", [["object-position", "right bottom"]]), n("object-right-top", [["object-position", "right top"]]), n("object-top", [["object-position", "top"]]), o("object", {
                themeKeys: ["--object-position"],
                handle: e => [y("object-position", e)]
            });
            for (let [e, t] of [["p", "padding"], ["px", "padding-inline"], ["py", "padding-block"], ["ps", "padding-inline-start"], ["pe", "padding-inline-end"], ["pt", "padding-top"], ["pr", "padding-right"], ["pb", "padding-bottom"], ["pl", "padding-left"]]) l(e, ["--padding", "--spacing"], (e => [y(t, e)]));
            n("text-left", [["text-align", "left"]]), n("text-center", [["text-align", "center"]]), n("text-right", [["text-align", "right"]]), n("text-justify", [["text-align", "justify"]]), n("text-start", [["text-align", "start"]]), n("text-end", [["text-align", "end"]]), l("indent", ["--text-indent", "--spacing"], (e => [y("text-indent", e)]), {supportsNegative: !0}), n("align-baseline", [["vertical-align", "baseline"]]), n("align-top", [["vertical-align", "top"]]), n("align-middle", [["vertical-align", "middle"]]), n("align-bottom", [["vertical-align", "bottom"]]), n("align-text-top", [["vertical-align", "text-top"]]), n("align-text-bottom", [["vertical-align", "text-bottom"]]), n("align-sub", [["vertical-align", "sub"]]), n("align-super", [["vertical-align", "super"]]), o("align", {
                themeKeys: [],
                handle: e => [y("vertical-align", e)]
            }), t.functional("font", (t => {
                if (t.value && !t.modifier) {
                    if ("arbitrary" === t.value.kind) {
                        let e = t.value.value;
                        switch (t.value.dataType ?? H(e, ["number", "generic-name", "family-name"])) {
                            case"generic-name":
                            case"family-name":
                                return [y("font-family", e)];
                            default:
                                return [A([be("--tw-font-weight")]), y("--tw-font-weight", e), y("font-weight", e)]
                        }
                    }
                    {
                        let r = e.resolveWith(t.value.value, ["--font"], ["--font-feature-settings", "--font-variation-settings"]);
                        if (r) {
                            let [e, t = {}] = r;
                            return [y("font-family", e), y("font-feature-settings", t["--font-feature-settings"]), y("font-variation-settings", t["--font-variation-settings"])]
                        }
                    }
                    {
                        let r = e.resolve(t.value.value, ["--font-weight"]);
                        if (r) return [A([be("--tw-font-weight")]), y("--tw-font-weight", r), y("font-weight", r)]
                    }
                }
            })), r("font", (() => [{values: [], valueThemeKeys: ["--font"]}, {
                values: [],
                valueThemeKeys: ["--font-weight"]
            }])), n("uppercase", [["text-transform", "uppercase"]]), n("lowercase", [["text-transform", "lowercase"]]), n("capitalize", [["text-transform", "capitalize"]]), n("normal-case", [["text-transform", "none"]]), n("italic", [["font-style", "italic"]]), n("not-italic", [["font-style", "normal"]]), n("underline", [["text-decoration-line", "underline"]]), n("overline", [["text-decoration-line", "overline"]]), n("line-through", [["text-decoration-line", "line-through"]]), n("no-underline", [["text-decoration-line", "none"]]), n("font-stretch-normal", [["font-stretch", "normal"]]), n("font-stretch-ultra-condensed", [["font-stretch", "ultra-condensed"]]), n("font-stretch-extra-condensed", [["font-stretch", "extra-condensed"]]), n("font-stretch-condensed", [["font-stretch", "condensed"]]), n("font-stretch-semi-condensed", [["font-stretch", "semi-condensed"]]), n("font-stretch-semi-expanded", [["font-stretch", "semi-expanded"]]), n("font-stretch-expanded", [["font-stretch", "expanded"]]), n("font-stretch-extra-expanded", [["font-stretch", "extra-expanded"]]), n("font-stretch-ultra-expanded", [["font-stretch", "ultra-expanded"]]), o("font-stretch", {
                handleBareValue: ({value: e}) => {
                    if (!e.endsWith("%")) return null;
                    let t = Number(e.slice(0, -1));
                    return !ae(t) || Number.isNaN(t) || t < 50 || t > 200 ? null : e
                }, handle: e => [y("font-stretch", e)]
            }), r("font-stretch", (() => [{values: ["50%", "75%", "90%", "95%", "100%", "105%", "110%", "125%", "150%", "200%"]}])), i("placeholder", {
                themeKeys: ["--background-color", "--color"],
                handle: e => [b("&::placeholder", [y("--tw-sort", "placeholder-color"), y("color", e)])]
            }), n("decoration-solid", [["text-decoration-style", "solid"]]), n("decoration-double", [["text-decoration-style", "double"]]), n("decoration-dotted", [["text-decoration-style", "dotted"]]), n("decoration-dashed", [["text-decoration-style", "dashed"]]), n("decoration-wavy", [["text-decoration-style", "wavy"]]), n("decoration-auto", [["text-decoration-thickness", "auto"]]), n("decoration-from-font", [["text-decoration-thickness", "from-font"]]), t.functional("decoration", (t => {
                if (t.value) {
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        switch (t.value.dataType ?? H(r, ["color", "length", "percentage"])) {
                            case"length":
                            case"percentage":
                                return t.modifier ? void 0 : [y("text-decoration-thickness", r)];
                            default:
                                return r = ke(r, t.modifier, e), null === r ? void 0 : [y("text-decoration-color", r)]
                        }
                    }
                    {
                        let r = e.resolve(t.value.value, ["--text-decoration-thickness"]);
                        if (r) return t.modifier ? void 0 : [y("text-decoration-thickness", r)];
                        if (ae(t.value.value)) return t.modifier ? void 0 : [y("text-decoration-thickness", `${t.value.value}px`)]
                    }
                    {
                        let r = ye(t, e, ["--text-decoration-color", "--color"]);
                        if (r) return [y("text-decoration-color", r)]
                    }
                }
            })), r("decoration", (() => [{
                values: ["current", "inherit", "transparent"],
                valueThemeKeys: ["--text-decoration-color", "--color"],
                modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
            }, {
                values: ["0", "1", "2"],
                valueThemeKeys: ["--text-decoration-thickness"]
            }])), n("animate-none", [["animation", "none"]]), o("animate", {
                themeKeys: ["--animate"],
                handle: e => [y("animation", e)]
            });
            {
                let e = ["var(--tw-blur,)", "var(--tw-brightness,)", "var(--tw-contrast,)", "var(--tw-grayscale,)", "var(--tw-hue-rotate,)", "var(--tw-invert,)", "var(--tw-saturate,)", "var(--tw-sepia,)", "var(--tw-drop-shadow,)"].join(" "),
                    i = ["var(--tw-backdrop-blur,)", "var(--tw-backdrop-brightness,)", "var(--tw-backdrop-contrast,)", "var(--tw-backdrop-grayscale,)", "var(--tw-backdrop-hue-rotate,)", "var(--tw-backdrop-invert,)", "var(--tw-backdrop-opacity,)", "var(--tw-backdrop-saturate,)", "var(--tw-backdrop-sepia,)"].join(" "),
                    l = () => A([be("--tw-blur"), be("--tw-brightness"), be("--tw-contrast"), be("--tw-grayscale"), be("--tw-hue-rotate"), be("--tw-invert"), be("--tw-opacity"), be("--tw-saturate"), be("--tw-sepia"), be("--tw-drop-shadow")]),
                    a = () => A([be("--tw-backdrop-blur"), be("--tw-backdrop-brightness"), be("--tw-backdrop-contrast"), be("--tw-backdrop-grayscale"), be("--tw-backdrop-hue-rotate"), be("--tw-backdrop-invert"), be("--tw-backdrop-opacity"), be("--tw-backdrop-saturate"), be("--tw-backdrop-sepia")]);
                t.functional("filter", (t => {
                    if (!t.modifier) {
                        if (null === t.value) return [l(), y("filter", e)];
                        if ("arbitrary" === t.value.kind) return [y("filter", t.value.value)];
                        if ("none" === t.value.value) return [y("filter", "none")]
                    }
                })), t.functional("backdrop-filter", (e => {
                    if (!e.modifier) {
                        if (null === e.value) return [a(), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)];
                        if ("arbitrary" === e.value.kind) return [y("-webkit-backdrop-filter", e.value.value), y("backdrop-filter", e.value.value)];
                        if ("none" === e.value.value) return [y("-webkit-backdrop-filter", "none"), y("backdrop-filter", "none")]
                    }
                })), o("blur", {
                    themeKeys: ["--blur"],
                    handle: t => [l(), y("--tw-blur", `blur(${t})`), y("filter", e)]
                }), n("blur-none", [l, ["--tw-blur", " "], ["filter", e]]), o("backdrop-blur", {
                    themeKeys: ["--backdrop-blur", "--blur"],
                    handle: e => [a(), y("--tw-backdrop-blur", `blur(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), n("backdrop-blur-none", [a, ["--tw-backdrop-blur", " "], ["-webkit-backdrop-filter", i], ["backdrop-filter", i]]), o("brightness", {
                    themeKeys: ["--brightness"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    handle: t => [l(), y("--tw-brightness", `brightness(${t})`), y("filter", e)]
                }), o("backdrop-brightness", {
                    themeKeys: ["--backdrop-brightness", "--brightness"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    handle: e => [a(), y("--tw-backdrop-brightness", `brightness(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("brightness", (() => [{
                    values: ["0", "50", "75", "90", "95", "100", "105", "110", "125", "150", "200"],
                    valueThemeKeys: ["--brightness"]
                }])), r("backdrop-brightness", (() => [{
                    values: ["0", "50", "75", "90", "95", "100", "105", "110", "125", "150", "200"],
                    valueThemeKeys: ["--backdrop-brightness", "--brightness"]
                }])), o("contrast", {
                    themeKeys: ["--contrast"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    handle: t => [l(), y("--tw-contrast", `contrast(${t})`), y("filter", e)]
                }), o("backdrop-contrast", {
                    themeKeys: ["--backdrop-contrast", "--contrast"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    handle: e => [a(), y("--tw-backdrop-contrast", `contrast(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("contrast", (() => [{
                    values: ["0", "50", "75", "100", "125", "150", "200"],
                    valueThemeKeys: ["--contrast"]
                }])), r("backdrop-contrast", (() => [{
                    values: ["0", "50", "75", "100", "125", "150", "200"],
                    valueThemeKeys: ["--backdrop-contrast", "--contrast"]
                }])), o("grayscale", {
                    themeKeys: ["--grayscale"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    defaultValue: "100%",
                    handle: t => [l(), y("--tw-grayscale", `grayscale(${t})`), y("filter", e)]
                }), o("backdrop-grayscale", {
                    themeKeys: ["--backdrop-grayscale", "--grayscale"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    defaultValue: "100%",
                    handle: e => [a(), y("--tw-backdrop-grayscale", `grayscale(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("grayscale", (() => [{
                    values: ["0", "25", "50", "75", "100"],
                    valueThemeKeys: ["--grayscale"],
                    hasDefaultValue: !0
                }])), r("backdrop-grayscale", (() => [{
                    values: ["0", "25", "50", "75", "100"],
                    valueThemeKeys: ["--backdrop-grayscale", "--grayscale"],
                    hasDefaultValue: !0
                }])), o("hue-rotate", {
                    supportsNegative: !0,
                    themeKeys: ["--hue-rotate"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}deg` : null,
                    handle: t => [l(), y("--tw-hue-rotate", `hue-rotate(${t})`), y("filter", e)]
                }), o("backdrop-hue-rotate", {
                    supportsNegative: !0,
                    themeKeys: ["--backdrop-hue-rotate", "--hue-rotate"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}deg` : null,
                    handle: e => [a(), y("--tw-backdrop-hue-rotate", `hue-rotate(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("hue-rotate", (() => [{
                    values: ["0", "15", "30", "60", "90", "180"],
                    valueThemeKeys: ["--hue-rotate"]
                }])), r("backdrop-hue-rotate", (() => [{
                    values: ["0", "15", "30", "60", "90", "180"],
                    valueThemeKeys: ["--backdrop-hue-rotate", "--hue-rotate"]
                }])), o("invert", {
                    themeKeys: ["--invert"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    defaultValue: "100%",
                    handle: t => [l(), y("--tw-invert", `invert(${t})`), y("filter", e)]
                }), o("backdrop-invert", {
                    themeKeys: ["--backdrop-invert", "--invert"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    defaultValue: "100%",
                    handle: e => [a(), y("--tw-backdrop-invert", `invert(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("invert", (() => [{
                    values: ["0", "25", "50", "75", "100"],
                    valueThemeKeys: ["--invert"],
                    hasDefaultValue: !0
                }])), r("backdrop-invert", (() => [{
                    values: ["0", "25", "50", "75", "100"],
                    valueThemeKeys: ["--backdrop-invert", "--invert"],
                    hasDefaultValue: !0
                }])), o("saturate", {
                    themeKeys: ["--saturate"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    handle: t => [l(), y("--tw-saturate", `saturate(${t})`), y("filter", e)]
                }), o("backdrop-saturate", {
                    themeKeys: ["--backdrop-saturate", "--saturate"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    handle: e => [a(), y("--tw-backdrop-saturate", `saturate(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("saturate", (() => [{
                    values: ["0", "50", "100", "150", "200"],
                    valueThemeKeys: ["--saturate"]
                }])), r("backdrop-saturate", (() => [{
                    values: ["0", "50", "100", "150", "200"],
                    valueThemeKeys: ["--backdrop-saturate", "--saturate"]
                }])), o("sepia", {
                    themeKeys: ["--sepia"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    defaultValue: "100%",
                    handle: t => [l(), y("--tw-sepia", `sepia(${t})`), y("filter", e)]
                }), o("backdrop-sepia", {
                    themeKeys: ["--backdrop-sepia", "--sepia"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}%` : null,
                    defaultValue: "100%",
                    handle: e => [a(), y("--tw-backdrop-sepia", `sepia(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("sepia", (() => [{
                    values: ["0", "50", "100"],
                    valueThemeKeys: ["--sepia"],
                    hasDefaultValue: !0
                }])), r("backdrop-sepia", (() => [{
                    values: ["0", "50", "100"],
                    valueThemeKeys: ["--backdrop-sepia", "--sepia"],
                    hasDefaultValue: !0
                }])), n("drop-shadow-none", [l, ["--tw-drop-shadow", " "], ["filter", e]]), o("drop-shadow", {
                    themeKeys: ["--drop-shadow"],
                    handle: t => [l(), y("--tw-drop-shadow", B(t, ",").map((e => `drop-shadow(${e})`)).join(" ")), y("filter", e)]
                }), o("backdrop-opacity", {
                    themeKeys: ["--backdrop-opacity", "--opacity"],
                    handleBareValue: ({value: e}) => ue(e) ? `${e}%` : null,
                    handle: e => [a(), y("--tw-backdrop-opacity", `opacity(${e})`), y("-webkit-backdrop-filter", i), y("backdrop-filter", i)]
                }), r("backdrop-opacity", (() => [{
                    values: Array.from({length: 21}, ((e, t) => "" + 5 * t)),
                    valueThemeKeys: ["--backdrop-opacity", "--opacity"]
                }]))
            }
            {
                let i = `var(--tw-ease, ${e.resolve(null, ["--default-transition-timing-function"]) ?? "ease"})`,
                    l = `var(--tw-duration, ${e.resolve(null, ["--default-transition-duration"]) ?? "0s"})`;
                n("transition-none", [["transition-property", "none"]]), n("transition-all", [["transition-property", "all"], ["transition-timing-function", i], ["transition-duration", l]]), n("transition-colors", [["transition-property", "color, background-color, border-color, outline-color, text-decoration-color, fill, stroke, --tw-gradient-from, --tw-gradient-via, --tw-gradient-to"], ["transition-timing-function", i], ["transition-duration", l]]), n("transition-opacity", [["transition-property", "opacity"], ["transition-timing-function", i], ["transition-duration", l]]), n("transition-shadow", [["transition-property", "box-shadow"], ["transition-timing-function", i], ["transition-duration", l]]), n("transition-transform", [["transition-property", "transform, translate, scale, rotate"], ["transition-timing-function", i], ["transition-duration", l]]), o("transition", {
                    defaultValue: "color, background-color, border-color, outline-color, text-decoration-color, fill, stroke, --tw-gradient-from, --tw-gradient-via, --tw-gradient-to, opacity, box-shadow, transform, translate, scale, rotate, filter, -webkit-backdrop-filter, backdrop-filter",
                    themeKeys: ["--transition-property"],
                    handle: e => [y("transition-property", e), y("transition-timing-function", i), y("transition-duration", l)]
                }), n("transition-discrete", [["transition-behavior", "allow-discrete"]]), n("transition-normal", [["transition-behavior", "normal"]]), o("delay", {
                    handleBareValue: ({value: e}) => ae(e) ? `${e}ms` : null,
                    themeKeys: ["--transition-delay"],
                    handle: e => [y("transition-delay", e)]
                });
                {
                    let r = () => A([be("--tw-duration")]);
                    n("duration-initial", [r, ["--tw-duration", "initial"]]), t.functional("duration", (t => {
                        if (t.modifier || !t.value) return;
                        let n = null;
                        return "arbitrary" === t.value.kind ? n = t.value.value : (n = e.resolve(t.value.fraction ?? t.value.value, ["--transition-duration"]), null === n && ae(t.value.value) && (n = `${t.value.value}ms`)), null !== n ? [r(), y("--tw-duration", n), y("transition-duration", n)] : void 0
                    }))
                }
                r("delay", (() => [{
                    values: ["75", "100", "150", "200", "300", "500", "700", "1000"],
                    valueThemeKeys: ["--transition-delay"]
                }])), r("duration", (() => [{
                    values: ["75", "100", "150", "200", "300", "500", "700", "1000"],
                    valueThemeKeys: ["--transition-duration"]
                }]))
            }
            {
                let e = () => A([be("--tw-ease")]);
                n("ease-initial", [e, ["--tw-ease", "initial"]]), n("ease-linear", [e, ["--tw-ease", "linear"], ["transition-timing-function", "linear"]]), o("ease", {
                    themeKeys: ["--ease"],
                    handle: t => [e(), y("--tw-ease", t), y("transition-timing-function", t)]
                })
            }
            n("will-change-auto", [["will-change", "auto"]]), n("will-change-scroll", [["will-change", "scroll-position"]]), n("will-change-contents", [["will-change", "contents"]]), n("will-change-transform", [["will-change", "transform"]]), o("will-change", {
                themeKeys: [],
                handle: e => [y("will-change", e)]
            }), n("content-none", [["--tw-content", "none"], ["content", "none"]]), o("content", {
                themeKeys: [],
                handle: e => [A([be("--tw-content", '""')]), y("--tw-content", e), y("content", "var(--tw-content)")]
            });
            {
                let e = "var(--tw-contain-size,) var(--tw-contain-layout,) var(--tw-contain-paint,) var(--tw-contain-style,)",
                    t = () => A([be("--tw-contain-size"), be("--tw-contain-layout"), be("--tw-contain-paint"), be("--tw-contain-style")]);
                n("contain-none", [["contain", "none"]]), n("contain-content", [["contain", "content"]]), n("contain-strict", [["contain", "strict"]]), n("contain-size", [t, ["--tw-contain-size", "size"], ["contain", e]]), n("contain-inline-size", [t, ["--tw-contain-size", "inline-size"], ["contain", e]]), n("contain-layout", [t, ["--tw-contain-layout", "layout"], ["contain", e]]), n("contain-paint", [t, ["--tw-contain-paint", "paint"], ["contain", e]]), n("contain-style", [t, ["--tw-contain-style", "style"], ["contain", e]]), o("contain", {
                    themeKeys: [],
                    handle: e => [y("contain", e)]
                })
            }
            n("forced-color-adjust-none", [["forced-color-adjust", "none"]]), n("forced-color-adjust-auto", [["forced-color-adjust", "auto"]]), n("leading-none", [() => A([be("--tw-leading")]), ["--tw-leading", "1"], ["line-height", "1"]]), l("leading", ["--leading", "--spacing"], (e => [A([be("--tw-leading")]), y("--tw-leading", e), y("line-height", e)])), o("tracking", {
                supportsNegative: !0,
                themeKeys: ["--tracking"],
                handle: e => [A([be("--tw-tracking")]), y("--tw-tracking", e), y("letter-spacing", e)]
            }), n("antialiased", [["-webkit-font-smoothing", "antialiased"], ["-moz-osx-font-smoothing", "grayscale"]]), n("subpixel-antialiased", [["-webkit-font-smoothing", "auto"], ["-moz-osx-font-smoothing", "auto"]]);
            {
                let e = "var(--tw-ordinal,) var(--tw-slashed-zero,) var(--tw-numeric-figure,) var(--tw-numeric-spacing,) var(--tw-numeric-fraction,)",
                    t = () => A([be("--tw-ordinal"), be("--tw-slashed-zero"), be("--tw-numeric-figure"), be("--tw-numeric-spacing"), be("--tw-numeric-fraction")]);
                n("normal-nums", [["font-variant-numeric", "normal"]]), n("ordinal", [t, ["--tw-ordinal", "ordinal"], ["font-variant-numeric", e]]), n("slashed-zero", [t, ["--tw-slashed-zero", "slashed-zero"], ["font-variant-numeric", e]]), n("lining-nums", [t, ["--tw-numeric-figure", "lining-nums"], ["font-variant-numeric", e]]), n("oldstyle-nums", [t, ["--tw-numeric-figure", "oldstyle-nums"], ["font-variant-numeric", e]]), n("proportional-nums", [t, ["--tw-numeric-spacing", "proportional-nums"], ["font-variant-numeric", e]]), n("tabular-nums", [t, ["--tw-numeric-spacing", "tabular-nums"], ["font-variant-numeric", e]]), n("diagonal-fractions", [t, ["--tw-numeric-fraction", "diagonal-fractions"], ["font-variant-numeric", e]]), n("stacked-fractions", [t, ["--tw-numeric-fraction", "stacked-fractions"], ["font-variant-numeric", e]])
            }
            {
                let i = () => A([be("--tw-outline-style", "solid")]);
                t.static("outline-hidden", (() => [y("--tw-outline-style", "none"), y("outline-style", "none"), w("@media", "(forced-colors: active)", [y("outline", "2px solid transparent"), y("outline-offset", "2px")])])), n("outline-none", [["--tw-outline-style", "none"], ["outline-style", "none"]]), n("outline-solid", [["--tw-outline-style", "solid"], ["outline-style", "solid"]]), n("outline-dashed", [["--tw-outline-style", "dashed"], ["outline-style", "dashed"]]), n("outline-dotted", [["--tw-outline-style", "dotted"], ["outline-style", "dotted"]]), n("outline-double", [["--tw-outline-style", "double"], ["outline-style", "double"]]), t.functional("outline", (t => {
                    if (null === t.value) {
                        if (t.modifier) return;
                        let r = e.get(["--default-outline-width"]) ?? "1px";
                        return [i(), y("outline-style", "var(--tw-outline-style)"), y("outline-width", r)]
                    }
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        switch (t.value.dataType ?? H(r, ["color", "length", "number", "percentage"])) {
                            case"length":
                            case"number":
                            case"percentage":
                                return t.modifier ? void 0 : [i(), y("outline-style", "var(--tw-outline-style)"), y("outline-width", r)];
                            default:
                                return r = ke(r, t.modifier, e), null === r ? void 0 : [y("outline-color", r)]
                        }
                    }
                    {
                        let r = ye(t, e, ["--outline-color", "--color"]);
                        if (r) return [y("outline-color", r)]
                    }
                    {
                        if (t.modifier) return;
                        let r = e.resolve(t.value.value, ["--outline-width"]);
                        if (r) return [i(), y("outline-style", "var(--tw-outline-style)"), y("outline-width", r)];
                        if (ae(t.value.value)) return [i(), y("outline-style", "var(--tw-outline-style)"), y("outline-width", `${t.value.value}px`)]
                    }
                })), r("outline", (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: ["--outline-color", "--color"],
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t)),
                    hasDefaultValue: !0
                }, {
                    values: ["0", "1", "2", "4", "8"],
                    valueThemeKeys: ["--outline-width"]
                }])), o("outline-offset", {
                    supportsNegative: !0,
                    themeKeys: ["--outline-offset"],
                    handleBareValue: ({value: e}) => ae(e) ? `${e}px` : null,
                    handle: e => [y("outline-offset", e)]
                }), r("outline-offset", (() => [{
                    supportsNegative: !0,
                    values: ["0", "1", "2", "4", "8"],
                    valueThemeKeys: ["--outline-offset"]
                }]))
            }
            o("opacity", {
                themeKeys: ["--opacity"],
                handleBareValue: ({value: e}) => ue(e) ? `${e}%` : null,
                handle: e => [y("opacity", e)]
            }), r("opacity", (() => [{
                values: Array.from({length: 21}, ((e, t) => "" + 5 * t)),
                valueThemeKeys: ["--opacity"]
            }])), n("underline-offset-auto", [["text-underline-offset", "auto"]]), o("underline-offset", {
                supportsNegative: !0,
                themeKeys: ["--text-underline-offset"],
                handleBareValue: ({value: e}) => ae(e) ? `${e}px` : null,
                handle: e => [y("text-underline-offset", e)]
            }), r("underline-offset", (() => [{
                supportsNegative: !0,
                values: ["0", "1", "2", "4", "8"],
                valueThemeKeys: ["--text-underline-offset"]
            }])), t.functional("text", (t => {
                if (t.value) {
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        switch (t.value.dataType ?? H(r, ["color", "length", "percentage", "absolute-size", "relative-size"])) {
                            case"size":
                            case"length":
                            case"percentage":
                            case"absolute-size":
                            case"relative-size":
                                if (t.modifier) {
                                    let n = "arbitrary" === t.modifier.kind ? t.modifier.value : e.resolve(t.modifier.value, ["--leading"]);
                                    if (!n && ce(t.modifier.value)) {
                                        let r = e.resolve(null, ["--spacing"]);
                                        if (!r) return null;
                                        n = `calc(${r} * ${t.modifier.value})`
                                    }
                                    return !n && "none" === t.modifier.value && (n = "1"), n ? [y("font-size", r), y("line-height", n)] : null
                                }
                                return [y("font-size", r)];
                            default:
                                return r = ke(r, t.modifier, e), null === r ? void 0 : [y("color", r)]
                        }
                    }
                    {
                        let r = ye(t, e, ["--text-color", "--color"]);
                        if (r) return [y("color", r)]
                    }
                    {
                        let r = e.resolveWith(t.value.value, ["--text"], ["--line-height", "--letter-spacing", "--font-weight"]);
                        if (r) {
                            let [n, o = {}] = Array.isArray(r) ? r : [r];
                            if (t.modifier) {
                                let r = "arbitrary" === t.modifier.kind ? t.modifier.value : e.resolve(t.modifier.value, ["--leading"]);
                                if (!r && ce(t.modifier.value)) {
                                    let n = e.resolve(null, ["--spacing"]);
                                    if (!n) return null;
                                    r = `calc(${n} * ${t.modifier.value})`
                                }
                                if (!r && "none" === t.modifier.value && (r = "1"), !r) return null;
                                let o = [y("font-size", n)];
                                return r && o.push(y("line-height", r)), o
                            }
                            return "string" == typeof o ? [y("font-size", n), y("line-height", o)] : [y("font-size", n), y("line-height", o["--line-height"] ? `var(--tw-leading, ${o["--line-height"]})` : void 0), y("letter-spacing", o["--letter-spacing"] ? `var(--tw-tracking, ${o["--letter-spacing"]})` : void 0), y("font-weight", o["--font-weight"] ? `var(--tw-font-weight, ${o["--font-weight"]})` : void 0)]
                        }
                    }
                }
            })), r("text", (() => [{
                values: ["current", "inherit", "transparent"],
                valueThemeKeys: ["--text-color", "--color"],
                modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
            }, {values: [], valueThemeKeys: ["--text"], modifiers: [], modifierThemeKeys: ["--leading"]}]));
            {
                let o = function (e) {
                        return `var(--tw-ring-inset,) 0 0 0 calc(${e} + var(--tw-ring-offset-width)) var(--tw-ring-color, ${c})`
                    }, i = function (e) {
                        return `inset 0 0 0 ${e} var(--tw-inset-ring-color, currentColor)`
                    },
                    l = ["var(--tw-inset-shadow)", "var(--tw-inset-ring-shadow)", "var(--tw-ring-offset-shadow)", "var(--tw-ring-shadow)", "var(--tw-shadow)"].join(", "),
                    a = "0 0 #0000",
                    s = () => A([be("--tw-shadow", a), be("--tw-shadow-color"), be("--tw-inset-shadow", a), be("--tw-inset-shadow-color"), be("--tw-ring-color"), be("--tw-ring-shadow", a), be("--tw-inset-ring-color"), be("--tw-inset-ring-shadow", a), be("--tw-ring-inset"), be("--tw-ring-offset-width", "0px", "<length>"), be("--tw-ring-offset-color", "#fff"), be("--tw-ring-offset-shadow", a)]);
                n("shadow-initial", [s, ["--tw-shadow-color", "initial"]]), t.functional("shadow", (t => {
                    if (!t.value) {
                        let t = e.get(["--shadow"]);
                        return null === t ? void 0 : [s(), y("--tw-shadow", pe(t, (e => `var(--tw-shadow-color, ${e})`))), y("box-shadow", l)]
                    }
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        return "color" === (t.value.dataType ?? H(r, ["color"])) ? (r = ke(r, t.modifier, e), null === r ? void 0 : [s(), y("--tw-shadow-color", r)]) : [s(), y("--tw-shadow", pe(r, (e => `var(--tw-shadow-color, ${e})`))), y("box-shadow", l)]
                    }
                    if ("none" === t.value.value) return t.modifier ? void 0 : [s(), y("--tw-shadow", a), y("box-shadow", l)];
                    {
                        let r = e.get([`--shadow-${t.value.value}`]);
                        if (r) return t.modifier ? void 0 : [s(), y("--tw-shadow", pe(r, (e => `var(--tw-shadow-color, ${e})`))), y("box-shadow", l)]
                    }
                    {
                        let r = ye(t, e, ["--box-shadow-color", "--color"]);
                        if (r) return [s(), y("--tw-shadow-color", r)]
                    }
                })), r("shadow", (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: ["--box-shadow-color", "--color"],
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
                }, {
                    values: ["none"],
                    valueThemeKeys: ["--shadow"],
                    hasDefaultValue: !0
                }])), n("inset-shadow-initial", [s, ["--tw-inset-shadow-color", "initial"]]), t.functional("inset-shadow", (t => {
                    if (!t.value) {
                        let t = e.get(["--inset-shadow"]);
                        return null === t ? void 0 : [s(), y("--tw-inset-shadow", pe(t, (e => `var(--tw-inset-shadow-color, ${e})`))), y("box-shadow", l)]
                    }
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        return "color" === (t.value.dataType ?? H(r, ["color"])) ? (r = ke(r, t.modifier, e), null === r ? void 0 : [s(), y("--tw-inset-shadow-color", r)]) : [s(), y("--tw-inset-shadow", `inset ${pe(r, (e => `var(--tw-inset-shadow-color, ${e})`))}`), y("box-shadow", l)]
                    }
                    if ("none" === t.value.value) return t.modifier ? void 0 : [s(), y("--tw-inset-shadow", a), y("box-shadow", l)];
                    {
                        let r = e.get([`--inset-shadow-${t.value.value}`]);
                        if (r) return t.modifier ? void 0 : [s(), y("--tw-inset-shadow", pe(r, (e => `var(--tw-inset-shadow-color, ${e})`))), y("box-shadow", l)]
                    }
                    {
                        let r = ye(t, e, ["--box-shadow-color", "--color"]);
                        if (r) return [s(), y("--tw-inset-shadow-color", r)]
                    }
                })), r("inset-shadow", (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: ["--box-shadow-color", "--color"],
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
                }, {
                    values: [],
                    valueThemeKeys: ["--inset-shadow"],
                    hasDefaultValue: !0
                }])), n("ring-inset", [s, ["--tw-ring-inset", "inset"]]);
                let c = e.get(["--default-ring-color"]) ?? "currentColor";
                t.functional("ring", (t => {
                    if (!t.value) {
                        if (t.modifier) return;
                        let r = e.get(["--default-ring-width"]) ?? "1px";
                        return [s(), y("--tw-ring-shadow", o(r)), y("box-shadow", l)]
                    }
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        return "length" === (t.value.dataType ?? H(r, ["color", "length"])) ? t.modifier ? void 0 : [s(), y("--tw-ring-shadow", o(r)), y("box-shadow", l)] : (r = ke(r, t.modifier, e), null === r ? void 0 : [y("--tw-ring-color", r)])
                    }
                    {
                        let r = ye(t, e, ["--ring-color", "--color"]);
                        if (r) return [y("--tw-ring-color", r)]
                    }
                    {
                        if (t.modifier) return;
                        let r = e.resolve(t.value.value, ["--ring-width"]);
                        if (null === r && ae(t.value.value) && (r = `${t.value.value}px`), r) return [s(), y("--tw-ring-shadow", o(r)), y("box-shadow", l)]
                    }
                })), r("ring", (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: ["--ring-color", "--color"],
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
                }, {
                    values: ["0", "1", "2", "4", "8"],
                    valueThemeKeys: ["--ring-width"],
                    hasDefaultValue: !0
                }])), t.functional("inset-ring", (t => {
                    if (!t.value) return t.modifier ? void 0 : [s(), y("--tw-inset-ring-shadow", i("1px")), y("box-shadow", l)];
                    if ("arbitrary" === t.value.kind) {
                        let r = t.value.value;
                        return "length" === (t.value.dataType ?? H(r, ["color", "length"])) ? t.modifier ? void 0 : [s(), y("--tw-inset-ring-shadow", i(r)), y("box-shadow", l)] : (r = ke(r, t.modifier, e), null === r ? void 0 : [y("--tw-inset-ring-color", r)])
                    }
                    {
                        let r = ye(t, e, ["--ring-color", "--color"]);
                        if (r) return [y("--tw-inset-ring-color", r)]
                    }
                    {
                        if (t.modifier) return;
                        let r = e.resolve(t.value.value, ["--ring-width"]);
                        if (null === r && ae(t.value.value) && (r = `${t.value.value}px`), r) return [s(), y("--tw-inset-ring-shadow", i(r)), y("box-shadow", l)]
                    }
                })), r("inset-ring", (() => [{
                    values: ["current", "inherit", "transparent"],
                    valueThemeKeys: ["--ring-color", "--color"],
                    modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
                }, {values: ["0", "1", "2", "4", "8"], valueThemeKeys: ["--ring-width"], hasDefaultValue: !0}]));
                let u = "var(--tw-ring-inset,) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color)";
                t.functional("ring-offset", (t => {
                    if (t.value) {
                        if ("arbitrary" === t.value.kind) {
                            let r = t.value.value;
                            return "length" === (t.value.dataType ?? H(r, ["color", "length"])) ? t.modifier ? void 0 : [y("--tw-ring-offset-width", r), y("--tw-ring-offset-shadow", u)] : (r = ke(r, t.modifier, e), null === r ? void 0 : [y("--tw-ring-offset-color", r)])
                        }
                        {
                            let r = e.resolve(t.value.value, ["--ring-offset-width"]);
                            if (r) return t.modifier ? void 0 : [y("--tw-ring-offset-width", r), y("--tw-ring-offset-shadow", u)];
                            if (ae(t.value.value)) return t.modifier ? void 0 : [y("--tw-ring-offset-width", `${t.value.value}px`), y("--tw-ring-offset-shadow", u)]
                        }
                        {
                            let r = ye(t, e, ["--ring-offset-color", "--color"]);
                            if (r) return [y("--tw-ring-offset-color", r)]
                        }
                    }
                }))
            }
            return r("ring-offset", (() => [{
                values: ["current", "inherit", "transparent"],
                valueThemeKeys: ["--ring-offset-color", "--color"],
                modifiers: Array.from({length: 21}, ((e, t) => "" + 5 * t))
            }, {
                values: ["0", "1", "2", "4", "8"],
                valueThemeKeys: ["--ring-offset-width"]
            }])), t.functional("@container", (e => {
                let t = null;
                if (null === e.value ? t = "inline-size" : "arbitrary" === e.value.kind ? t = e.value.value : "named" === e.value.kind && "normal" === e.value.value && (t = "normal"), null !== t) return e.modifier ? [y("container-type", t), y("container-name", e.modifier.value)] : [y("container-type", t)]
            })), r("@container", (() => [{values: ["normal"], valueThemeKeys: [], hasDefaultValue: !0}])), t
        }(e), r = function (e) {
            let t = new Ve;

            function r(e, r, {compounds: n} = {}) {
                n = n ?? Ne(r), t.static(e, (e => {
                    e.nodes = r.map((t => k(t, e.nodes)))
                }), {compounds: n})
            }

            function n(e, t) {
                return t.map((t => {
                    let r = B(t = t.trim(), " ");
                    return "not" === r[0] ? r.slice(1).join(" ") : "@container" === e ? "(" === r[0][0] ? `not ${t}` : "not" === r[1] ? `${r[0]} ${r.slice(2).join(" ")}` : `${r[0]} not ${r.slice(1).join(" ")}` : `not ${t}`
                }))
            }

            r("*", [":is(& > *)"], {compounds: 0}), r("**", [":is(& *)"], {compounds: 0});
            let o = ["@media", "@supports", "@container"];

            function i(e) {
                for (let t of o) {
                    if (t !== e.name) continue;
                    let r = B(e.params, ",");
                    return r.length > 1 ? null : (r = n(e.name, r), w(e.name, r.join(", ")))
                }
                return null
            }

            function l(e) {
                return e.includes("::") ? null : `&:not(${B(e, ",").map((e => e.replaceAll("&", "*"))).join(", ")})`
            }

            t.compound("not", 3, ((e, t) => {
                if ("arbitrary" === t.variant.kind && t.variant.relative || t.modifier) return null;
                let r = !1;
                return z([e], ((t, {path: n}) => {
                    if ("rule" !== t.kind && "at-rule" !== t.kind) return 0;
                    if (t.nodes.length > 0) return 0;
                    let o = [], a = [];
                    for (let e of n) "at-rule" === e.kind ? o.push(e) : "rule" === e.kind && a.push(e);
                    if (o.length > 1) return 2;
                    if (a.length > 1) return 2;
                    let s = [];
                    for (let e of a) {
                        let t = l(e.selector);
                        if (!t) return r = !1, 2;
                        s.push(b(t, []))
                    }
                    for (let e of o) {
                        let t = i(e);
                        if (!t) return r = !1, 2;
                        s.push(t)
                    }
                    return Object.assign(e, b("&", s)), r = !0, 1
                })), "rule" === e.kind && "&" === e.selector && 1 === e.nodes.length && Object.assign(e, e.nodes[0]), r ? void 0 : null
            })), t.suggest("not", (() => Array.from(t.keys()).filter((e => t.compoundsWith("not", e))))), t.compound("group", 2, ((t, r) => {
                if ("arbitrary" === r.variant.kind && r.variant.relative) return null;
                let n = r.modifier ? `:where(.${e.prefix ? `${e.prefix}\\:` : ""}group\\/${r.modifier.value})` : `:where(.${e.prefix ? `${e.prefix}\\:` : ""}group)`,
                    o = !1;
                return z([t], ((e, {path: t}) => {
                    if ("rule" !== e.kind) return 0;
                    for (let e of t.slice(0, -1)) if ("rule" === e.kind) return o = !1, 2;
                    let r = e.selector.replaceAll("&", n);
                    B(r, ",").length > 1 && (r = `:is(${r})`), e.selector = `&:is(${r} *)`, o = !0
                })), o ? void 0 : null
            })), t.suggest("group", (() => Array.from(t.keys()).filter((e => t.compoundsWith("group", e))))), t.compound("peer", 2, ((t, r) => {
                if ("arbitrary" === r.variant.kind && r.variant.relative) return null;
                let n = r.modifier ? `:where(.${e.prefix ? `${e.prefix}\\:` : ""}peer\\/${r.modifier.value})` : `:where(.${e.prefix ? `${e.prefix}\\:` : ""}peer)`,
                    o = !1;
                return z([t], ((e, {path: t}) => {
                    if ("rule" !== e.kind) return 0;
                    for (let e of t.slice(0, -1)) if ("rule" === e.kind) return o = !1, 2;
                    let r = e.selector.replaceAll("&", n);
                    B(r, ",").length > 1 && (r = `:is(${r})`), e.selector = `&:is(${r} ~ *)`, o = !0
                })), o ? void 0 : null
            })), t.suggest("peer", (() => Array.from(t.keys()).filter((e => t.compoundsWith("peer", e))))), r("first-letter", ["&::first-letter"]), r("first-line", ["&::first-line"]), r("marker", ["& *::marker", "&::marker"]), r("selection", ["& *::selection", "&::selection"]), r("file", ["&::file-selector-button"]), r("placeholder", ["&::placeholder"]), r("backdrop", ["&::backdrop"]);
            {
                let e = function () {
                    return A([w("@property", "--tw-content", [y("syntax", '"*"'), y("initial-value", '""'), y("inherits", "false")])])
                };
                t.static("before", (t => {
                    t.nodes = [b("&::before", [e(), y("content", "var(--tw-content)"), ...t.nodes])]
                }), {compounds: 0}), t.static("after", (t => {
                    t.nodes = [b("&::after", [e(), y("content", "var(--tw-content)"), ...t.nodes])]
                }), {compounds: 0})
            }
            r("first", ["&:first-child"]), r("last", ["&:last-child"]), r("only", ["&:only-child"]), r("odd", ["&:nth-child(odd)"]), r("even", ["&:nth-child(even)"]), r("first-of-type", ["&:first-of-type"]), r("last-of-type", ["&:last-of-type"]), r("only-of-type", ["&:only-of-type"]), r("visited", ["&:visited"]), r("target", ["&:target"]), r("open", ["&:is([open], :popover-open, :open)"]), r("default", ["&:default"]), r("checked", ["&:checked"]), r("indeterminate", ["&:indeterminate"]), r("placeholder-shown", ["&:placeholder-shown"]), r("autofill", ["&:autofill"]), r("optional", ["&:optional"]), r("required", ["&:required"]), r("valid", ["&:valid"]), r("invalid", ["&:invalid"]), r("in-range", ["&:in-range"]), r("out-of-range", ["&:out-of-range"]), r("read-only", ["&:read-only"]), r("empty", ["&:empty"]), r("focus-within", ["&:focus-within"]), t.static("hover", (e => {
                e.nodes = [b("&:hover", [w("@media", "(hover: hover)", e.nodes)])]
            })), r("focus", ["&:focus"]), r("focus-visible", ["&:focus-visible"]), r("active", ["&:active"]), r("enabled", ["&:enabled"]), r("disabled", ["&:disabled"]), r("inert", ["&:is([inert], [inert] *)"]), t.compound("in", 2, ((e, t) => {
                if (t.modifier) return null;
                let r = !1;
                return z([e], ((e, {path: t}) => {
                    if ("rule" !== e.kind) return 0;
                    for (let e of t.slice(0, -1)) if ("rule" === e.kind) return r = !1, 2;
                    e.selector = `:where(${e.selector.replaceAll("&", "*")}) &`, r = !0
                })), r ? void 0 : null
            })), t.suggest("in", (() => Array.from(t.keys()).filter((e => t.compoundsWith("in", e))))), t.compound("has", 2, ((e, t) => {
                if (t.modifier) return null;
                let r = !1;
                return z([e], ((e, {path: t}) => {
                    if ("rule" !== e.kind) return 0;
                    for (let e of t.slice(0, -1)) if ("rule" === e.kind) return r = !1, 2;
                    e.selector = `&:has(${e.selector.replaceAll("&", "*")})`, r = !0
                })), r ? void 0 : null
            })), t.suggest("has", (() => Array.from(t.keys()).filter((e => t.compoundsWith("has", e))))), t.functional("aria", ((e, t) => {
                if (!t.value || t.modifier) return null;
                "arbitrary" === t.value.kind ? e.nodes = [b(`&[aria-${Oe(t.value.value)}]`, e.nodes)] : e.nodes = [b(`&[aria-${t.value.value}="true"]`, e.nodes)]
            })), t.suggest("aria", (() => ["busy", "checked", "disabled", "expanded", "hidden", "pressed", "readonly", "required", "selected"])), t.functional("data", ((e, t) => {
                if (!t.value || t.modifier) return null;
                e.nodes = [b(`&[data-${Oe(t.value.value)}]`, e.nodes)]
            })), t.functional("nth", ((e, t) => {
                if (!t.value || t.modifier || "named" === t.value.kind && !ae(t.value.value)) return null;
                e.nodes = [b(`&:nth-child(${t.value.value})`, e.nodes)]
            })), t.functional("nth-last", ((e, t) => {
                if (!t.value || t.modifier || "named" === t.value.kind && !ae(t.value.value)) return null;
                e.nodes = [b(`&:nth-last-child(${t.value.value})`, e.nodes)]
            })), t.functional("nth-of-type", ((e, t) => {
                if (!t.value || t.modifier || "named" === t.value.kind && !ae(t.value.value)) return null;
                e.nodes = [b(`&:nth-of-type(${t.value.value})`, e.nodes)]
            })), t.functional("nth-last-of-type", ((e, t) => {
                if (!t.value || t.modifier || "named" === t.value.kind && !ae(t.value.value)) return null;
                e.nodes = [b(`&:nth-last-of-type(${t.value.value})`, e.nodes)]
            })), t.functional("supports", ((e, t) => {
                if (!t.value || t.modifier) return null;
                let r = t.value.value;
                if (null === r) return null;
                if (/^[\w-]*\s*\(/.test(r)) {
                    let t = r.replace(/\b(and|or|not)\b/g, " $1 ");
                    e.nodes = [w("@supports", t, e.nodes)]
                } else r.includes(":") || (r = `${r}: var(--tw)`), ("(" !== r[0] || ")" !== r[r.length - 1]) && (r = `(${r})`), e.nodes = [w("@supports", r, e.nodes)]
            }), {compounds: 1}), r("motion-safe", ["@media (prefers-reduced-motion: no-preference)"]), r("motion-reduce", ["@media (prefers-reduced-motion: reduce)"]), r("contrast-more", ["@media (prefers-contrast: more)"]), r("contrast-less", ["@media (prefers-contrast: less)"]);
            {
                let r = function (e, t, r, n) {
                    if (e === t) return 0;
                    let o = n.get(e);
                    if (null === o) return "asc" === r ? -1 : 1;
                    let i = n.get(t);
                    return null === i ? "asc" === r ? 1 : -1 : R(o, i, r)
                };
                {
                    let n = e.namespace("--breakpoint"), o = new c((t => {
                        switch (t.kind) {
                            case"static":
                                return e.resolveValue(t.root, ["--breakpoint"]) ?? null;
                            case"functional": {
                                if (!t.value || t.modifier) return null;
                                let r = null;
                                return "arbitrary" === t.value.kind ? r = t.value.value : "named" === t.value.kind && (r = e.resolveValue(t.value.value, ["--breakpoint"])), !r || r.includes("var(") ? null : r
                            }
                            case"arbitrary":
                            case"compound":
                                return null
                        }
                    }));
                    t.group((() => {
                        t.functional("max", ((e, t) => {
                            if (t.modifier) return null;
                            let r = o.get(t);
                            if (null === r) return null;
                            e.nodes = [w("@media", `(width < ${r})`, e.nodes)]
                        }), {compounds: 1})
                    }), ((e, t) => r(e, t, "desc", o))), t.suggest("max", (() => Array.from(n.keys()).filter((e => null !== e)))), t.group((() => {
                        for (let [r, n] of e.namespace("--breakpoint")) null !== r && t.static(r, (e => {
                            e.nodes = [w("@media", `(width >= ${n})`, e.nodes)]
                        }), {compounds: 1});
                        t.functional("min", ((e, t) => {
                            if (t.modifier) return null;
                            let r = o.get(t);
                            if (null === r) return null;
                            e.nodes = [w("@media", `(width >= ${r})`, e.nodes)]
                        }), {compounds: 1})
                    }), ((e, t) => r(e, t, "asc", o))), t.suggest("min", (() => Array.from(n.keys()).filter((e => null !== e))))
                }
                {
                    let n = e.namespace("--container"), o = new c((t => {
                        switch (t.kind) {
                            case"functional": {
                                if (null === t.value) return null;
                                let r = null;
                                return "arbitrary" === t.value.kind ? r = t.value.value : "named" === t.value.kind && (r = e.resolveValue(t.value.value, ["--container"])), !r || r.includes("var(") ? null : r
                            }
                            case"static":
                            case"arbitrary":
                            case"compound":
                                return null
                        }
                    }));
                    t.group((() => {
                        t.functional("@max", ((e, t) => {
                            let r = o.get(t);
                            if (null === r) return null;
                            e.nodes = [w("@container", t.modifier ? `${t.modifier.value} (width < ${r})` : `(width < ${r})`, e.nodes)]
                        }), {compounds: 1})
                    }), ((e, t) => r(e, t, "desc", o))), t.suggest("@max", (() => Array.from(n.keys()).filter((e => null !== e)))), t.group((() => {
                        t.functional("@", ((e, t) => {
                            let r = o.get(t);
                            if (null === r) return null;
                            e.nodes = [w("@container", t.modifier ? `${t.modifier.value} (width >= ${r})` : `(width >= ${r})`, e.nodes)]
                        }), {compounds: 1}), t.functional("@min", ((e, t) => {
                            let r = o.get(t);
                            if (null === r) return null;
                            e.nodes = [w("@container", t.modifier ? `${t.modifier.value} (width >= ${r})` : `(width >= ${r})`, e.nodes)]
                        }), {compounds: 1})
                    }), ((e, t) => r(e, t, "asc", o))), t.suggest("@min", (() => Array.from(n.keys()).filter((e => null !== e)))), t.suggest("@", (() => Array.from(n.keys()).filter((e => null !== e))))
                }
            }
            return r("portrait", ["@media (orientation: portrait)"]), r("landscape", ["@media (orientation: landscape)"]), r("ltr", ['&:where(:dir(ltr), [dir="ltr"], [dir="ltr"] *)']), r("rtl", ['&:where(:dir(rtl), [dir="rtl"], [dir="rtl"] *)']), r("dark", ["@media (prefers-color-scheme: dark)"]), r("starting", ["@starting-style"]), r("print", ["@media print"]), r("forced-colors", ["@media (forced-colors: active)"]), t
        }(e), n = new c((e => function (e, t) {
            if ("[" === e[0] && "]" === e[e.length - 1]) {
                if ("@" === e[1] && e.includes("&")) return null;
                let t = F(e.slice(1, -1));
                if (0 === t.length || 0 === t.trim().length) return null;
                let r = ">" === t[0] || "+" === t[0] || "~" === t[0];
                return !r && "@" !== t[0] && !t.includes("&") && (t = `&:is(${t})`), {
                    kind: "arbitrary",
                    selector: t,
                    relative: r
                }
            }
            {
                let [r, n = null, o] = B(e, "/");
                if (o) return null;
                let i = M(r, (e => t.variants.has(e)));
                for (let [e, r] of i) switch (t.variants.kind(e)) {
                    case"static":
                        return null !== r || null !== n ? null : {kind: "static", root: e};
                    case"functional": {
                        let t = null === n ? null : L(n);
                        if (null !== n && null === t) return null;
                        if (null === r) return {kind: "functional", root: e, modifier: t, value: null};
                        if ("]" === r[r.length - 1]) {
                            if ("[" !== r[0]) continue;
                            let n = F(r.slice(1, -1));
                            return 0 === n.length || 0 === n.trim().length ? null : {
                                kind: "functional",
                                root: e,
                                modifier: t,
                                value: {kind: "arbitrary", value: n}
                            }
                        }
                        if (")" === r[r.length - 1]) {
                            if ("(" !== r[0]) continue;
                            let n = F(r.slice(1, -1));
                            return 0 === n.length || 0 === n.trim().length || "-" !== n[0] && "-" !== n[1] ? null : {
                                kind: "functional",
                                root: e,
                                modifier: t,
                                value: {kind: "arbitrary", value: `var(${n})`}
                            }
                        }
                        return {kind: "functional", root: e, modifier: t, value: {kind: "named", value: r}}
                    }
                    case"compound": {
                        if (null === r) return null;
                        let o = t.parseVariant(r);
                        if (null === o || !t.variants.compoundsWith(e, o)) return null;
                        let i = null === n ? null : L(n);
                        return null !== n && null === i ? null : {kind: "compound", root: e, modifier: i, variant: o}
                    }
                }
            }
            return null
        }(e, s))), i = new c((e => Array.from(function* (e, t) {
            let r = B(e, ":");
            if (t.theme.prefix) {
                if (1 === r.length || r[0] !== t.theme.prefix) return null;
                r.shift()
            }
            let n = r.pop(), o = [];
            for (let e = r.length - 1; e >= 0; --e) {
                let n = t.parseVariant(r[e]);
                if (null === n) return;
                o.push(n)
            }
            let i = !1;
            "!" === n[n.length - 1] ? (i = !0, n = n.slice(0, -1)) : "!" === n[0] && (i = !0, n = n.slice(1)), t.utilities.has(n, "static") && !n.includes("[") && (yield{
                kind: "static",
                root: n,
                variants: o,
                important: i,
                raw: e
            });
            let [l, a = null, s] = B(n, "/");
            if (s) return;
            let c, u = null === a ? null : L(a);
            if (null === a || null !== u) if ("[" !== l[0]) {
                if ("]" === l[l.length - 1]) {
                    let e = l.indexOf("-[");
                    if (-1 === e) return;
                    let r = l.slice(0, e);
                    if (!t.utilities.has(r, "functional")) return;
                    c = [[r, l.slice(e + 1)]]
                } else if (")" === l[l.length - 1]) {
                    let e = l.indexOf("-(");
                    if (-1 === e) return;
                    let r = l.slice(0, e);
                    if (!t.utilities.has(r, "functional")) return;
                    let n = l.slice(e + 2, -1), o = B(n, ":"), i = null;
                    if (2 === o.length && (i = o[0], n = o[1]), "-" !== n[0] && "-" !== n[1]) return;
                    c = [[r, null === i ? `[var(${n})]` : `[${i}:var(${n})]`]]
                } else c = M(l, (e => t.utilities.has(e, "functional")));
                for (let [t, r] of c) {
                    let n = {kind: "functional", root: t, modifier: u, value: null, variants: o, important: i, raw: e};
                    if (null !== r) {
                        {
                            let e = r.indexOf("[");
                            if (-1 !== e) {
                                if ("]" !== r[r.length - 1]) return;
                                let t = F(r.slice(e + 1, -1)), o = "";
                                for (let e = 0; e < t.length; e++) {
                                    let r = t.charCodeAt(e);
                                    if (58 === r) {
                                        o = t.slice(0, e), t = t.slice(e + 1);
                                        break
                                    }
                                    if (!(45 === r || r >= 97 && r <= 122)) break
                                }
                                if (0 === t.length || 0 === t.trim().length) continue;
                                n.value = {kind: "arbitrary", dataType: o || null, value: t}
                            } else {
                                let e = null === a || "arbitrary" === n.modifier?.kind ? null : `${r}/${a}`;
                                n.value = {kind: "named", value: r, fraction: e}
                            }
                        }
                        yield n
                    } else yield n
                }
            } else {
                if ("]" !== l[l.length - 1]) return;
                let t = l.charCodeAt(1);
                if (45 !== t && !(t >= 97 && t <= 122)) return;
                l = l.slice(1, -1);
                let r = l.indexOf(":");
                if (-1 === r || 0 === r || r === l.length - 1) return;
                let n = l.slice(0, r), a = F(l.slice(r + 1));
                yield{kind: "arbitrary", property: n, value: a, modifier: u, variants: o, important: i, raw: e}
            }
        }(e, s)))), l = new c((e => {
            let t = function (e, t) {
                let r = function (e, t) {
                    if ("arbitrary" === e.kind) {
                        let r = e.value;
                        return e.modifier && (r = ke(r, e.modifier, t.theme)), null === r ? [] : [[y(e.property, r)]]
                    }
                    let r = t.utilities.get(e.root) ?? [], n = [], o = r.filter((e => !Be(e)));
                    for (let t of o) {
                        if (t.kind !== e.kind) continue;
                        let r = t.compileFn(e);
                        if (void 0 !== r) {
                            if (null === r) return n;
                            n.push(r)
                        }
                    }
                    if (n.length > 0) return n;
                    let i = r.filter((e => Be(e)));
                    for (let t of i) {
                        if (t.kind !== e.kind) continue;
                        let r = t.compileFn(e);
                        if (void 0 !== r) {
                            if (null === r) return n;
                            n.push(r)
                        }
                    }
                    return n
                }(e, t);
                if (0 === r.length) return [];
                let n = [], i = `.${o(e.raw)}`;
                for (let o of r) {
                    let r = Me(o);
                    (e.important || t.important) && Le(o);
                    let l = {kind: "rule", selector: i, nodes: o};
                    for (let r of e.variants) if (null === _e(l, r, t.variants)) return [];
                    n.push({node: l, propertySort: r})
                }
                return n
            }(e, s);
            try {
                Ce(t.map((({node: e}) => e)), s)
            } catch {
                return []
            }
            return t
        })), a = new c((t => {
            for (let r of g(t)) e.markUsedVariable(r)
        })), s = {
            theme: e,
            utilities: t,
            variants: r,
            invalidCandidates: new Set,
            important: !1,
            candidatesToCss(e) {
                let t = [];
                for (let r of e) {
                    let e = !1, {astNodes: n} = De([r], this, {
                        onInvalidCandidate() {
                            e = !0
                        }
                    });
                    n = T(n, s), 0 === n.length || e ? t.push(null) : t.push(j(n))
                }
                return t
            },
            getClassOrder(e) {
                return function (e, t) {
                    let {astNodes: r, nodeSorting: n} = De(Array.from(t), e), o = new Map(t.map((e => [e, null]))),
                        i = 0n;
                    for (let e of r) {
                        let t = n.get(e)?.candidate;
                        t && o.set(t, o.get(t) ?? i++)
                    }
                    return t.map((e => [e, o.get(e) ?? null]))
                }(this, e)
            },
            getClassList() {
                return Se(this)
            },
            getVariants() {
                return function (e) {
                    let t = [];
                    for (let [r, n] of e.variants.entries()) {
                        let o = function ({value: t, modifier: n} = {}) {
                            let o = r;
                            t && (o += i ? `-${t}` : t), n && (o += `/${n}`);
                            let l = e.parseVariant(o);
                            if (!l) return [];
                            let a = b(".__placeholder__", []);
                            if (null === _e(a, l, e.variants)) return [];
                            let s = [];
                            return C(a.nodes, ((e, {path: t}) => {
                                if ("rule" !== e.kind && "at-rule" !== e.kind || e.nodes.length > 0) return;
                                t.sort(((e, t) => {
                                    let r = "at-rule" === e.kind, n = "at-rule" === t.kind;
                                    return r && !n ? -1 : !r && n ? 1 : 0
                                }));
                                let r = t.flatMap((e => "rule" === e.kind ? "&" === e.selector ? [] : [e.selector] : "at-rule" === e.kind ? [`${e.name} ${e.params}`] : [])),
                                    n = "";
                                for (let e = r.length - 1; e >= 0; e--) n = "" === n ? r[e] : `${r[e]} { ${n} }`;
                                s.push(n)
                            })), s
                        };
                        if ("arbitrary" === n.kind) continue;
                        let i = "@" !== r, l = e.variants.getCompletions(r);
                        switch (n.kind) {
                            case"static":
                                t.push({name: r, values: l, isArbitrary: !1, hasDash: i, selectors: o});
                                break;
                            case"functional":
                            case"compound":
                                t.push({name: r, values: l, isArbitrary: !0, hasDash: i, selectors: o})
                        }
                    }
                    return t
                }(this)
            },
            parseCandidate: e => i.get(e),
            parseVariant: e => n.get(e),
            compileAstNodes: e => l.get(e),
            getVariantOrder() {
                let e = Array.from(n.values());
                e.sort(((e, t) => this.variants.compare(e, t)));
                let t, r = new Map, o = 0;
                for (let n of e) null !== n && (void 0 !== t && 0 !== this.variants.compare(t, n) && o++, r.set(n, o), t = n);
                return r
            },
            resolveThemeValue(t) {
                let r = t.lastIndexOf("/"), n = null;
                -1 !== r && (n = t.slice(r + 1).trim(), t = t.slice(0, r).trim());
                let o = e.get([t]) ?? void 0;
                return n && o ? we(o, n) : o
            },
            trackUsedVariables(e) {
                a.get(e)
            }
        };
        return s
    }

    var We = ["container-type", "pointer-events", "visibility", "position", "inset", "inset-inline", "inset-block", "inset-inline-start", "inset-inline-end", "top", "right", "bottom", "left", "isolation", "z-index", "order", "grid-column", "grid-column-start", "grid-column-end", "grid-row", "grid-row-start", "grid-row-end", "float", "clear", "--tw-container-component", "margin", "margin-inline", "margin-block", "margin-inline-start", "margin-inline-end", "margin-top", "margin-right", "margin-bottom", "margin-left", "box-sizing", "display", "field-sizing", "aspect-ratio", "height", "max-height", "min-height", "width", "max-width", "min-width", "flex", "flex-shrink", "flex-grow", "flex-basis", "table-layout", "caption-side", "border-collapse", "border-spacing", "transform-origin", "translate", "--tw-translate-x", "--tw-translate-y", "--tw-translate-z", "scale", "--tw-scale-x", "--tw-scale-y", "--tw-scale-z", "rotate", "--tw-rotate-x", "--tw-rotate-y", "--tw-rotate-z", "--tw-skew-x", "--tw-skew-y", "transform", "animation", "cursor", "touch-action", "--tw-pan-x", "--tw-pan-y", "--tw-pinch-zoom", "resize", "scroll-snap-type", "--tw-scroll-snap-strictness", "scroll-snap-align", "scroll-snap-stop", "scroll-margin", "scroll-margin-inline", "scroll-margin-block", "scroll-margin-inline-start", "scroll-margin-inline-end", "scroll-margin-top", "scroll-margin-right", "scroll-margin-bottom", "scroll-margin-left", "scroll-padding", "scroll-padding-inline", "scroll-padding-block", "scroll-padding-inline-start", "scroll-padding-inline-end", "scroll-padding-top", "scroll-padding-right", "scroll-padding-bottom", "scroll-padding-left", "list-style-position", "list-style-type", "list-style-image", "appearance", "columns", "break-before", "break-inside", "break-after", "grid-auto-columns", "grid-auto-flow", "grid-auto-rows", "grid-template-columns", "grid-template-rows", "flex-direction", "flex-wrap", "place-content", "place-items", "align-content", "align-items", "justify-content", "justify-items", "gap", "column-gap", "row-gap", "--tw-space-x-reverse", "--tw-space-y-reverse", "divide-x-width", "divide-y-width", "--tw-divide-y-reverse", "divide-style", "divide-color", "place-self", "align-self", "justify-self", "overflow", "overflow-x", "overflow-y", "overscroll-behavior", "overscroll-behavior-x", "overscroll-behavior-y", "scroll-behavior", "border-radius", "border-start-radius", "border-end-radius", "border-top-radius", "border-right-radius", "border-bottom-radius", "border-left-radius", "border-start-start-radius", "border-start-end-radius", "border-end-end-radius", "border-end-start-radius", "border-top-left-radius", "border-top-right-radius", "border-bottom-right-radius", "border-bottom-left-radius", "border-width", "border-inline-width", "border-block-width", "border-inline-start-width", "border-inline-end-width", "border-top-width", "border-right-width", "border-bottom-width", "border-left-width", "border-style", "border-inline-style", "border-block-style", "border-inline-start-style", "border-inline-end-style", "border-top-style", "border-right-style", "border-bottom-style", "border-left-style", "border-color", "border-inline-color", "border-block-color", "border-inline-start-color", "border-inline-end-color", "border-top-color", "border-right-color", "border-bottom-color", "border-left-color", "background-color", "background-image", "--tw-gradient-position", "--tw-gradient-stops", "--tw-gradient-via-stops", "--tw-gradient-from", "--tw-gradient-from-position", "--tw-gradient-via", "--tw-gradient-via-position", "--tw-gradient-to", "--tw-gradient-to-position", "box-decoration-break", "background-size", "background-attachment", "background-clip", "background-position", "background-repeat", "background-origin", "fill", "stroke", "stroke-width", "object-fit", "object-position", "padding", "padding-inline", "padding-block", "padding-inline-start", "padding-inline-end", "padding-top", "padding-right", "padding-bottom", "padding-left", "text-align", "text-indent", "vertical-align", "font-family", "font-size", "line-height", "font-weight", "letter-spacing", "text-wrap", "overflow-wrap", "word-break", "text-overflow", "hyphens", "white-space", "color", "text-transform", "font-style", "font-stretch", "font-variant-numeric", "text-decoration-line", "text-decoration-color", "text-decoration-style", "text-decoration-thickness", "text-underline-offset", "-webkit-font-smoothing", "placeholder-color", "caret-color", "accent-color", "color-scheme", "opacity", "background-blend-mode", "mix-blend-mode", "box-shadow", "--tw-shadow", "--tw-shadow-color", "--tw-ring-shadow", "--tw-ring-color", "--tw-inset-shadow", "--tw-inset-shadow-color", "--tw-inset-ring-shadow", "--tw-inset-ring-color", "--tw-ring-offset-width", "--tw-ring-offset-color", "outline", "outline-width", "outline-offset", "outline-color", "--tw-blur", "--tw-brightness", "--tw-contrast", "--tw-drop-shadow", "--tw-grayscale", "--tw-hue-rotate", "--tw-invert", "--tw-saturate", "--tw-sepia", "filter", "--tw-backdrop-blur", "--tw-backdrop-brightness", "--tw-backdrop-contrast", "--tw-backdrop-grayscale", "--tw-backdrop-hue-rotate", "--tw-backdrop-invert", "--tw-backdrop-opacity", "--tw-backdrop-saturate", "--tw-backdrop-sepia", "backdrop-filter", "transition-property", "transition-behavior", "transition-delay", "transition-duration", "transition-timing-function", "will-change", "contain", "content", "forced-color-adjust"];

    function De(e, t, {onInvalidCandidate: r} = {}) {
        let n = new Map, o = [], i = new Map;
        for (let n of e) {
            if (t.invalidCandidates.has(n)) {
                r?.(n);
                continue
            }
            let e = t.parseCandidate(n);
            0 !== e.length ? i.set(n, e) : r?.(n)
        }
        let l = t.getVariantOrder();
        for (let [e, a] of i) {
            let i = !1;
            for (let r of a) {
                let a = t.compileAstNodes(r);
                if (0 !== a.length) {
                    i = !0;
                    for (let {node: t, propertySort: i} of a) {
                        let a = 0n;
                        for (let e of r.variants) a |= 1n << BigInt(l.get(e));
                        n.set(t, {properties: i, variants: a, candidate: e}), o.push(t)
                    }
                }
            }
            i || r?.(e)
        }
        return o.sort(((e, t) => {
            let r = n.get(e), o = n.get(t);
            if (r.variants - o.variants !== 0n) return Number(r.variants - o.variants);
            let i = 0;
            for (; i < r.properties.order.length && i < o.properties.order.length && r.properties.order[i] === o.properties.order[i];) i += 1;
            return (r.properties.order[i] ?? 1 / 0) - (o.properties.order[i] ?? 1 / 0) || o.properties.count - r.properties.count || je(r.candidate, o.candidate)
        })), {astNodes: o, nodeSorting: n}
    }

    function _e(e, t, r, n = 0) {
        if ("arbitrary" === t.kind) return t.relative && 0 === n ? null : void (e.nodes = [k(t.selector, e.nodes)]);
        let {applyFn: o} = r.get(t.root);
        if ("compound" === t.kind) {
            let i = w("@slot");
            if (null === _e(i, t.variant, r, n + 1) || "not" === t.root && i.nodes.length > 1) return null;
            for (let e of i.nodes) if ("rule" !== e.kind && "at-rule" !== e.kind || null === o(e, t)) return null;
            return z(i.nodes, (t => {
                if (("rule" === t.kind || "at-rule" === t.kind) && t.nodes.length <= 0) return t.nodes = e.nodes, 1
            })), void (e.nodes = i.nodes)
        }
        return null === o(e, t) ? null : void 0
    }

    function Be(e) {
        let t = e.options?.types ?? [];
        return t.length > 1 && t.includes("any")
    }

    function Le(e) {
        for (let t of e) "at-root" !== t.kind && ("declaration" === t.kind ? t.important = !0 : ("rule" === t.kind || "at-rule" === t.kind) && Le(t.nodes))
    }

    function Me(e) {
        let t = new Set, r = 0, n = e.slice(), o = !1;
        for (; n.length > 0;) {
            let e = n.shift();
            if ("declaration" === e.kind) {
                if (void 0 === e.value || (r++, o)) continue;
                if ("--tw-sort" === e.property) {
                    let r = We.indexOf(e.value ?? "");
                    if (-1 !== r) {
                        t.add(r), o = !0;
                        continue
                    }
                }
                let n = We.indexOf(e.property);
                -1 !== n && t.add(n)
            } else if ("rule" === e.kind || "at-rule" === e.kind) for (let t of e.nodes) n.push(t)
        }
        return {order: Array.from(t).sort(((e, t) => e - t)), count: r}
    }

    function Re(e, t) {
        let r = 0, n = k("&", e), o = new Set, i = new c((() => new Set)), l = new c((() => new Set));
        z([n], ((e, {parent: n}) => {
            if ("at-rule" === e.kind) {
                if ("@keyframes" === e.name) return z(e.nodes, (e => {
                    if ("at-rule" === e.kind && "@apply" === e.name) throw new Error("You cannot use `@apply` inside `@keyframes`.")
                })), 1;
                if ("@utility" === e.name) {
                    let r = e.params.replace(/-\*$/, "");
                    return l.get(r).add(e), void z(e.nodes, (r => {
                        if ("at-rule" === r.kind && "@apply" === r.name) {
                            o.add(e);
                            for (let n of Ie(r, t)) i.get(e).add(n)
                        }
                    }))
                }
                if ("@apply" === e.name) {
                    if (null === n) return;
                    r |= 1, o.add(n);
                    for (let r of Ie(e, t)) i.get(n).add(r)
                }
            }
        }));
        let a = new Set, s = [], u = new Set;

        function d(e, r = []) {
            if (!a.has(e)) {
                if (u.has(e)) {
                    let n = r[(r.indexOf(e) + 1) % r.length];
                    throw "at-rule" === e.kind && "@utility" === e.name && "at-rule" === n.kind && "@utility" === n.name && z(e.nodes, (e => {
                        if ("at-rule" !== e.kind || "@apply" !== e.name) return;
                        let r = e.params.split(/\s+/g);
                        for (let e of r) for (let r of t.parseCandidate(e)) switch (r.kind) {
                            case"arbitrary":
                                break;
                            case"static":
                            case"functional":
                                if (n.params.replace(/-\*$/, "") === r.root) throw new Error(`You cannot \`@apply\` the \`${e}\` utility here because it creates a circular dependency.`)
                        }
                    })), new Error(`Circular dependency detected:\n\n${j([e])}\nRelies on:\n\n${j([n])}`)
                }
                u.add(e);
                for (let t of i.get(e)) for (let n of l.get(t)) r.push(e), d(n, r), r.pop();
                a.add(e), u.delete(e), s.push(e)
            }
        }

        for (let e of o) d(e);
        for (let e of s) if ("nodes" in e) for (let r = 0; r < e.nodes.length; r++) {
            let n = e.nodes[r];
            if ("at-rule" === n.kind && "@apply" === n.name) {
                let o = De(n.params.split(/\s+/g), t, {
                    onInvalidCandidate: e => {
                        throw new Error(`Cannot apply unknown utility class: ${e}`)
                    }
                }).astNodes, i = [];
                for (let e of o) if ("rule" === e.kind) for (let t of e.nodes) i.push(t); else i.push(e);
                e.nodes.splice(r, 1, ...i)
            }
        }
        return r
    }

    function* Ie(e, t) {
        for (let r of e.params.split(/\s+/g)) for (let e of t.parseCandidate(r)) switch (e.kind) {
            case"arbitrary":
                break;
            case"static":
            case"functional":
                yield e.root
        }
    }

    async function qe(e, r, n, o = 0) {
        let i = 0, l = [];
        return z(e, ((e, {replaceWith: a}) => {
            if ("at-rule" === e.kind && ("@import" === e.name || "@reference" === e.name)) {
                let s = function (e) {
                    let t, r = null, n = null, o = null;
                    for (let i = 0; i < e.length; i++) {
                        let l = e[i];
                        if ("separator" !== l.kind) {
                            if ("word" === l.kind && !t) {
                                if (!l.value || '"' !== l.value[0] && "'" !== l.value[0]) return null;
                                t = l.value.slice(1, -1);
                                continue
                            }
                            if ("function" === l.kind && "url" === l.value.toLowerCase() || !t) return null;
                            if (("word" === l.kind || "function" === l.kind) && "layer" === l.value.toLowerCase()) {
                                if (r) return null;
                                if (o) throw new Error("`layer(…)` in an `@import` should come before any other functions or conditions");
                                r = "nodes" in l ? p(l.nodes) : "";
                                continue
                            }
                            if ("function" === l.kind && "supports" === l.value.toLowerCase()) {
                                if (o) return null;
                                o = p(l.nodes);
                                continue
                            }
                            n = p(e.slice(i));
                            break
                        }
                    }
                    return t ? {uri: t, layer: r, media: n, supports: o} : null
                }(m(e.params));
                if (null === s) return;
                "@reference" === e.name && (s.media = "reference"), i |= 2;
                let {uri: c, layer: u, media: d, supports: f} = s;
                if (c.startsWith("data:") || c.startsWith("http://") || c.startsWith("https://")) return;
                let h = $({}, []);
                return l.push((async () => {
                    if (o > 100) throw new Error(`Exceeded maximum recursion depth while resolving \`${c}\` in \`${r}\`)`);
                    let e = await n(c, r), i = t(e.content);
                    await qe(i, e.base, n, o + 1), h.nodes = function (e, t, r, n) {
                        let o = e;
                        return null !== t && (o = [w("@layer", t, o)]), null !== r && (o = [w("@media", r, o)]), null !== n && (o = [w("@supports", "(" === n[0] ? n : `(${n})`, o)]), o
                    }([$({base: e.base}, i)], u, d, f)
                })()), a(h), 1
            }
        })), l.length > 0 && await Promise.all(l), i
    }

    function Pe(e, t = null) {
        return Array.isArray(e) && 2 === e.length && "object" == typeof e[1] && null !== typeof e[1] ? t ? e[1][t] ?? null : e[0] : Array.isArray(e) && null === t ? e.join(", ") : "string" == typeof e && null === t ? e : null
    }

    function He(e, {theme: t}, r) {
        for (let t of r) {
            let r = Ze([t]);
            r && e.theme.clearNamespace(`--${r}`, 4)
        }
        for (let [r, n] of function (e) {
            let t = [];
            return Ge(e, [], ((e, r) => {
                if (function (e) {
                    return "number" == typeof e || "string" == typeof e
                }(e)) return t.push([r, e]), 1;
                if (function (e) {
                    if (!Array.isArray(e) || 2 !== e.length || "string" != typeof e[0] && "number" != typeof e[0] || void 0 === e[1] || null === e[1] || "object" != typeof e[1]) return !1;
                    for (let t of Reflect.ownKeys(e[1])) if ("string" != typeof t || "string" != typeof e[1][t] && "number" != typeof e[1][t]) return !1;
                    return !0
                }(e)) {
                    t.push([r, e[0]]);
                    for (let n of Reflect.ownKeys(e[1])) t.push([[...r, `-${n}`], e[1][n]]);
                    return 1
                }
                return Array.isArray(e) && e.every((e => "string" == typeof e)) ? (t.push([r, e.join(", ")]), 1) : void 0
            })), t
        }(t)) {
            if ("string" != typeof n && "number" != typeof n) continue;
            if ("string" == typeof n && (n = n.replace(/<alpha-value>/g, "1")), "opacity" === r[0] && ("number" == typeof n || "string" == typeof n)) {
                let e = "string" == typeof n ? parseFloat(n) : n;
                e >= 0 && e <= 1 && (n = 100 * e + "%")
            }
            let t = Ze(r);
            t && e.theme.add(`--${t}`, "" + n, 7)
        }
        if (Object.hasOwn(t, "fontFamily")) {
            let r = 5;
            {
                let n = Pe(t.fontFamily.sans);
                n && e.theme.hasDefault("--font-sans") && (e.theme.add("--default-font-family", n, r), e.theme.add("--default-font-feature-settings", Pe(t.fontFamily.sans, "fontFeatureSettings") ?? "normal", r), e.theme.add("--default-font-variation-settings", Pe(t.fontFamily.sans, "fontVariationSettings") ?? "normal", r))
            }
            {
                let n = Pe(t.fontFamily.mono);
                n && e.theme.hasDefault("--font-mono") && (e.theme.add("--default-mono-font-family", n, r), e.theme.add("--default-mono-font-feature-settings", Pe(t.fontFamily.mono, "fontFeatureSettings") ?? "normal", r), e.theme.add("--default-mono-font-variation-settings", Pe(t.fontFamily.mono, "fontVariationSettings") ?? "normal", r))
            }
        }
        return t
    }

    var Ye = /^[a-zA-Z0-9-_%/\.]+$/;

    function Ze(e) {
        if ("container" === e[0]) return null;
        "animation" === (e = structuredClone(e))[0] && (e[0] = "animate"), "aspectRatio" === e[0] && (e[0] = "aspect"), "borderRadius" === e[0] && (e[0] = "radius"), "boxShadow" === e[0] && (e[0] = "shadow"), "colors" === e[0] && (e[0] = "color"), "containers" === e[0] && (e[0] = "container"), "fontFamily" === e[0] && (e[0] = "font"), "fontSize" === e[0] && (e[0] = "text"), "letterSpacing" === e[0] && (e[0] = "tracking"), "lineHeight" === e[0] && (e[0] = "leading"), "maxWidth" === e[0] && (e[0] = "container"), "screens" === e[0] && (e[0] = "breakpoint"), "transitionTimingFunction" === e[0] && (e[0] = "ease");
        for (let t of e) if (!Ye.test(t)) return null;
        return e.map(((e, t, r) => "1" === e && t !== r.length - 1 ? "" : e)).map((e => e.replaceAll(".", "_").replace(/([a-z])([A-Z])/g, ((e, t, r) => `${t}-${r.toLowerCase()}`)))).filter(((t, r) => "DEFAULT" !== t || r !== e.length - 1)).join("-")
    }

    function Ge(e, t = [], r) {
        for (let n of Reflect.ownKeys(e)) {
            let o = e[n];
            if (null == o) continue;
            let i = [...t, n], l = r(o, i) ?? 0;
            if (1 !== l) {
                if (2 === l) return 2;
                if ((Array.isArray(o) || "object" == typeof o) && 2 === Ge(o, i, r)) return 2
            }
        }
    }

    function Xe(e) {
        let t = [];
        for (let r of B(e, ".")) {
            if (!r.includes("[")) {
                t.push(r);
                continue
            }
            let e = 0;
            for (; ;) {
                let n = r.indexOf("[", e), o = r.indexOf("]", n);
                if (-1 === n || -1 === o) break;
                n > e && t.push(r.slice(e, n)), t.push(r.slice(n + 1, o)), e = o + 1
            }
            e <= r.length - 1 && t.push(r.slice(e))
        }
        return t
    }

    function Je(e) {
        if ("[object Object]" !== Object.prototype.toString.call(e)) return !1;
        let t = Object.getPrototypeOf(e);
        return null === t || null === Object.getPrototypeOf(t)
    }

    function Qe(e, t, r, n = []) {
        for (let o of t) if (null != o) for (let t of Reflect.ownKeys(o)) {
            n.push(t);
            let i = r(e[t], o[t], n);
            void 0 !== i ? e[t] = i : Je(e[t]) && Je(o[t]) ? e[t] = Qe({}, [e[t], o[t]], r, n) : e[t] = o[t], n.pop()
        }
        return e
    }

    function et(e, t, r) {
        return function (n, o) {
            let l = n.lastIndexOf("/"), a = null;
            -1 !== l && (a = n.slice(l + 1).trim(), n = n.slice(0, l).trim());
            let s = (() => {
                let o = Xe(n), [l, a] = function (e, t) {
                    if (1 === t.length && t[0].startsWith("--")) return [e.get([t[0]]), e.getOptions(t[0])];
                    let r = Ze(t), n = new Map, o = new c((() => new Map)), i = e.namespace(`--${r}`);
                    if (0 === i.size) return [null, 0];
                    let l = new Map;
                    for (let [t, a] of i) {
                        if (!t || !t.includes("--")) {
                            n.set(t, a), l.set(t, e.getOptions(t ? `--${r}-${t}` : `--${r}`));
                            continue
                        }
                        let i = t.indexOf("--"), s = t.slice(0, i), c = t.slice(i + 2);
                        c = c.replace(/-([a-z])/g, ((e, t) => t.toUpperCase())), o.get("" === s ? null : s).set(c, [a, e.getOptions(`--${r}${t}`)])
                    }
                    let a = e.getOptions(`--${r}`);
                    for (let [e, t] of o) {
                        let r = n.get(e);
                        if ("string" != typeof r) continue;
                        let o = {}, i = {};
                        for (let [e, [r, n]] of t) o[e] = r, i[e] = n;
                        n.set(e, [r, o]), l.set(e, [a, i])
                    }
                    let s = {}, u = {};
                    for (let [e, t] of n) rt(s, [e ?? "DEFAULT"], t);
                    for (let [e, t] of l) rt(u, [e ?? "DEFAULT"], t);
                    return "DEFAULT" === t[t.length - 1] ? [s?.DEFAULT ?? null, u.DEFAULT ?? 0] : "DEFAULT" in s && 1 === Object.keys(s).length ? [s.DEFAULT, u.DEFAULT ?? 0] : (s.__CSS_VALUES__ = u, [s, u])
                }(e.theme, o), s = r(tt(t() ?? {}, o) ?? null);
                if ("string" == typeof s && (s = s.replace("<alpha-value>", "1")), "object" != typeof l) return "object" != typeof a && 4 & a ? s ?? l : l;
                if (null !== s && "object" == typeof s && !Array.isArray(s)) {
                    let e = Qe({}, [s], ((e, t) => t));
                    if (null === l && Object.hasOwn(s, "__CSS_VALUES__")) {
                        let t = {};
                        for (let r in s.__CSS_VALUES__) t[r] = s[r], delete e[r];
                        l = t
                    }
                    for (let t in l) "__CSS_VALUES__" !== t && (4 & s?.__CSS_VALUES__?.[t] && void 0 !== tt(e, t.split("-")) || (e[i(t)] = l[t]));
                    return e
                }
                if (Array.isArray(l) && Array.isArray(a) && Array.isArray(s)) {
                    let e = l[0], t = l[1];
                    4 & a[0] && (e = s[0] ?? e);
                    for (let e of Object.keys(t)) 4 & a[1][e] && (t[e] = s[1][e] ?? t[e]);
                    return [e, t]
                }
                return l ?? s
            })();
            return a && "string" == typeof s && (s = we(s, a)), s ?? o
        }
    }

    function tt(e, t) {
        for (let r = 0; r < t.length; ++r) {
            let n = t[r];
            if (void 0 !== e?.[n]) e = e[n]; else {
                if (void 0 === t[r + 1]) return;
                t[r + 1] = `${n}-${t[r + 1]}`
            }
        }
        return e
    }

    function rt(e, t, r) {
        for (let r of t.slice(0, -1)) void 0 === e[r] && (e[r] = {}), e = e[r];
        e[t[t.length - 1]] = r
    }

    function nt(e) {
        return {kind: "combinator", value: e}
    }

    function ot(e, t) {
        return {kind: "function", value: e, nodes: t}
    }

    function it(e) {
        return {kind: "selector", value: e}
    }

    function lt(e) {
        return {kind: "separator", value: e}
    }

    function at(e) {
        return {kind: "value", value: e}
    }

    function st(e, t, r = null) {
        for (let n = 0; n < e.length; n++) {
            let o = e[n], i = !1, l = 0, a = t(o, {
                parent: r, replaceWith(t) {
                    i = !0, Array.isArray(t) ? 0 === t.length ? (e.splice(n, 1), l = 0) : 1 === t.length ? (e[n] = t[0], l = 1) : (e.splice(n, 1, ...t), l = t.length) : (e[n] = t, l = 1)
                }
            }) ?? 0;
            if (i) 0 === a ? n-- : n += l - 1; else {
                if (2 === a) return 2;
                if (1 !== a && "function" === o.kind && 2 === st(o.nodes, t, o)) return 2
            }
        }
    }

    function ct(e) {
        let t = "";
        for (let r of e) switch (r.kind) {
            case"combinator":
            case"selector":
            case"separator":
            case"value":
                t += r.value;
                break;
            case"function":
                t += r.value + "(" + ct(r.nodes) + ")"
        }
        return t
    }

    function ut(e) {
        e = e.replaceAll("\r\n", "\n");
        let t, r = [], n = [], o = null, i = "";
        for (let l = 0; l < e.length; l++) {
            let a = e.charCodeAt(l);
            switch (a) {
                case 44:
                case 62:
                case 10:
                case 32:
                case 43:
                case 9:
                case 126: {
                    if (i.length > 0) {
                        let e = it(i);
                        o ? o.nodes.push(e) : r.push(e), i = ""
                    }
                    let n = l, a = l + 1;
                    for (; a < e.length && (t = e.charCodeAt(a), 44 === t || 62 === t || 10 === t || 32 === t || 43 === t || 9 === t || 126 === t); a++) ;
                    l = a - 1;
                    let s = e.slice(n, a), c = "," === s.trim() ? lt(s) : nt(s);
                    o ? o.nodes.push(c) : r.push(c);
                    break
                }
                case 40: {
                    let a = ot(i, []);
                    if (i = "", ":not" !== a.value && ":where" !== a.value && ":has" !== a.value && ":is" !== a.value) {
                        let n = l + 1, s = 0;
                        for (let r = l + 1; r < e.length; r++) if (t = e.charCodeAt(r), 40 !== t) {
                            if (41 === t) {
                                if (0 === s) {
                                    l = r;
                                    break
                                }
                                s--
                            }
                        } else s++;
                        let c = l;
                        a.nodes.push(at(e.slice(n, c))), i = "", l = c, o ? o.nodes.push(a) : r.push(a);
                        break
                    }
                    o ? o.nodes.push(a) : r.push(a), n.push(a), o = a;
                    break
                }
                case 41: {
                    let e = n.pop();
                    if (i.length > 0) {
                        let t = it(i);
                        e.nodes.push(t), i = ""
                    }
                    o = n.length > 0 ? n[n.length - 1] : null;
                    break
                }
                case 46:
                case 58:
                case 35:
                    if (i.length > 0) {
                        let e = it(i);
                        o ? o.nodes.push(e) : r.push(e)
                    }
                    i = String.fromCharCode(a);
                    break;
                case 91: {
                    if (i.length > 0) {
                        let e = it(i);
                        o ? o.nodes.push(e) : r.push(e)
                    }
                    i = "";
                    let n = l, a = 0;
                    for (let r = l + 1; r < e.length; r++) if (t = e.charCodeAt(r), 91 !== t) {
                        if (93 === t) {
                            if (0 === a) {
                                l = r;
                                break
                            }
                            a--
                        }
                    } else a++;
                    i += e.slice(n, l + 1);
                    break
                }
                case 39:
                case 34: {
                    let r = l;
                    for (let r = l + 1; r < e.length; r++) if (t = e.charCodeAt(r), 92 === t) r += 1; else if (t === a) {
                        l = r;
                        break
                    }
                    i += e.slice(r, l + 1);
                    break
                }
                case 92: {
                    let t = e.charCodeAt(l + 1);
                    i += String.fromCharCode(a) + String.fromCharCode(t), l += 1;
                    break
                }
                default:
                    i += String.fromCharCode(a)
            }
        }
        return i.length > 0 && r.push(it(i)), r
    }

    var dt = /^[a-z@][a-zA-Z0-9/%._-]*$/;

    function ft({designSystem: e, ast: t, resolvedConfig: r, featuresRef: n, referenceMode: o}) {
        let i = {
            addBase(r) {
                if (o) return;
                let i = ht(r);
                n.current |= Ce(i, e), t.push(w("@layer", "base", i))
            }, addVariant(t, r) {
                if (!Ee.test(t)) throw new Error(`\`addVariant('${t}')\` defines an invalid variant name. Variants should only contain alphanumeric, dashes or underscore characters.`);
                "string" == typeof r || Array.isArray(r) ? e.variants.static(t, (e => {
                    e.nodes = pt(r, e.nodes)
                }), {compounds: Ne("string" == typeof r ? [r] : r)}) : "object" == typeof r && e.variants.fromAst(t, ht(r))
            }, matchVariant(t, r, n) {
                function o(e, t, n) {
                    return pt(r(e, {modifier: t?.value ?? null}), n)
                }

                let i = Object.keys(n?.values ?? {});
                e.variants.group((() => {
                    e.variants.functional(t, ((e, t) => {
                        if (!t.value) return n?.values && "DEFAULT" in n.values ? void (e.nodes = o(n.values.DEFAULT, t.modifier, e.nodes)) : null;
                        if ("arbitrary" === t.value.kind) e.nodes = o(t.value.value, t.modifier, e.nodes); else if ("named" === t.value.kind && n?.values) {
                            let r = n.values[t.value.value];
                            if ("string" != typeof r) return;
                            e.nodes = o(r, t.modifier, e.nodes)
                        }
                    }))
                }), ((e, t) => {
                    if ("functional" !== e.kind || "functional" !== t.kind) return 0;
                    let r = e.value ? e.value.value : "DEFAULT", o = t.value ? t.value.value : "DEFAULT",
                        l = n?.values?.[r] ?? r, a = n?.values?.[o] ?? o;
                    if (n && "function" == typeof n.sort) return n.sort({
                        value: l,
                        modifier: e.modifier?.value ?? null
                    }, {value: a, modifier: t.modifier?.value ?? null});
                    let s = i.indexOf(r), c = i.indexOf(o);
                    return s = -1 === s ? i.length : s, c = -1 === c ? i.length : c, s !== c ? s - c : l < a ? -1 : 1
                }))
            }, addUtilities(r) {
                let i = (r = Array.isArray(r) ? r : [r]).flatMap((e => Object.entries(e)));
                i = i.flatMap((([e, t]) => B(e, ",").map((e => [e.trim(), t]))));
                let l = new c((() => []));
                for (let [e, r] of i) {
                    if (e.startsWith("@keyframes ")) {
                        o || t.push(k(e, ht(r)));
                        continue
                    }
                    let n = ut(e), i = !1;
                    if (st(n, (e => {
                        if ("selector" === e.kind && "." === e.value[0] && dt.test(e.value.slice(1))) {
                            let t = e.value;
                            e.value = "&";
                            let o = ct(n), a = t.slice(1), s = "&" === o ? ht(r) : [k(o, ht(r))];
                            return l.get(a).push(...s), i = !0, void (e.value = t)
                        }
                        if ("function" === e.kind && ":not" === e.value) return 1
                    })), !i) throw new Error(`\`addUtilities({ '${e}' : … })\` defines an invalid utility selector. Utilities must be a single class name and start with a lowercase letter, eg. \`.scrollbar-none\`.`)
                }
                for (let [t, r] of l) e.theme.prefix && z(r, (t => {
                    if ("rule" === t.kind) {
                        let r = ut(t.selector);
                        st(r, (t => {
                            "selector" === t.kind && "." === t.value[0] && (t.value = `.${e.theme.prefix}\\:${t.value.slice(1)}`)
                        })), t.selector = ct(r)
                    }
                })), e.utilities.static(t, (o => {
                    let i = structuredClone(r);
                    return mt(i, t, o.raw), n.current |= Re(i, e), i
                }))
            }, matchUtilities(t, r) {
                let o = r?.type ? Array.isArray(r?.type) ? r.type : [r.type] : ["any"];
                for (let [i, l] of Object.entries(t)) {
                    let t = function ({negative: t}) {
                        return a => {
                            if ("arbitrary" === a.value?.kind && o.length > 0 && !o.includes("any") && (a.value.dataType && !o.includes(a.value.dataType) || !a.value.dataType && !H(a.value.value, o))) return;
                            let s, c = o.includes("color"), u = null, d = !1;
                            {
                                let e = r?.values ?? {};
                                c && (e = Object.assign({
                                    inherit: "inherit",
                                    transparent: "transparent",
                                    current: "currentColor"
                                }, e)), a.value ? "arbitrary" === a.value.kind ? u = a.value.value : a.value.fraction && e[a.value.fraction] ? (u = e[a.value.fraction], d = !0) : e[a.value.value] ? u = e[a.value.value] : e.__BARE_VALUE__ && (u = e.__BARE_VALUE__(a.value) ?? null, d = (null !== a.value.fraction && u?.includes("/")) ?? !1) : u = e.DEFAULT ?? null
                            }
                            if (null === u) return;
                            {
                                let e = r?.modifiers ?? null;
                                s = a.modifier ? "any" === e || "arbitrary" === a.modifier.kind ? a.modifier.value : e?.[a.modifier.value] ? e[a.modifier.value] : c && !Number.isNaN(Number(a.modifier.value)) ? `${a.modifier.value}%` : null : null
                            }
                            if (a.modifier && null === s && !d) return "arbitrary" === a.value?.kind ? null : void 0;
                            c && null !== s && (u = we(u, s)), t && (u = `calc(${u} * -1)`);
                            let f = ht(l(u, {modifier: s}));
                            return mt(f, i, a.raw), n.current |= Re(f, e), f
                        }
                    };
                    if (!dt.test(i)) throw new Error(`\`matchUtilities({ '${i}' : … })\` defines an invalid utility name. Utilities should be alphanumeric and start with a lowercase letter, eg. \`scrollbar\`.`);
                    r?.supportsNegativeValues && e.utilities.functional(`-${i}`, t({negative: !0}), {types: o}), e.utilities.functional(i, t({negative: !1}), {types: o}), e.utilities.suggest(i, (() => {
                        let e = r?.values ?? {}, t = new Set(Object.keys(e));
                        t.delete("__BARE_VALUE__"), t.has("DEFAULT") && (t.delete("DEFAULT"), t.add(null));
                        let n = r?.modifiers ?? {}, o = "any" === n ? [] : Object.keys(n);
                        return [{
                            supportsNegative: r?.supportsNegativeValues ?? !1,
                            values: Array.from(t),
                            modifiers: o
                        }]
                    }))
                }
            }, addComponents(e, t) {
                this.addUtilities(e, t)
            }, matchComponents(e, t) {
                this.matchUtilities(e, t)
            }, theme: et(e, (() => r.theme ?? {}), (e => e)), prefix: e => e, config(e, t) {
                let n = r;
                if (!e) return n;
                let o = Xe(e);
                for (let e = 0; e < o.length; ++e) {
                    let r = o[e];
                    if (void 0 === n[r]) return t;
                    n = n[r]
                }
                return n ?? t
            }
        };
        return i.addComponents = i.addComponents.bind(i), i.matchComponents = i.matchComponents.bind(i), i
    }

    function ht(e) {
        let t = [], r = (e = Array.isArray(e) ? e : [e]).flatMap((e => Object.entries(e)));
        for (let [e, n] of r) if ("object" != typeof n) {
            if (!e.startsWith("--")) {
                if ("@slot" === n) {
                    t.push(k(e, [w("@slot")]));
                    continue
                }
                e = e.replace(/([A-Z])/g, "-$1").toLowerCase()
            }
            t.push(y(e, String(n)))
        } else if (Array.isArray(n)) for (let r of n) "string" == typeof r ? t.push(y(e, r)) : t.push(k(e, ht(r))); else null !== n && t.push(k(e, ht(n)));
        return t
    }

    function pt(e, r) {
        return ("string" == typeof e ? [e] : e).flatMap((e => {
            if (e.trim().endsWith("}")) {
                let n = t(e.replace("}", "{@slot}}"));
                return Fe(n, r), n
            }
            return k(e, r)
        }))
    }

    function mt(e, t, r) {
        z(e, (e => {
            if ("rule" === e.kind) {
                let n = ut(e.selector);
                st(n, (e => {
                    "selector" === e.kind && e.value === `.${t}` && (e.value = `.${o(r)}`)
                })), e.selector = ct(n)
            }
        }))
    }

    function gt(e, t, r) {
        for (let r of function (e) {
            let t = [];
            if ("keyframes" in e.theme) for (let [r, n] of Object.entries(e.theme.keyframes)) t.push(w("@keyframes", r, ht(n)));
            return t
        }(t)) e.theme.addKeyframes(r)
    }

    var vt = {
        inherit: "inherit",
        current: "currentColor",
        transparent: "transparent",
        black: "#000",
        white: "#fff",
        slate: {
            50: "oklch(0.984 0.003 247.858)",
            100: "oklch(0.968 0.007 247.896)",
            200: "oklch(0.929 0.013 255.508)",
            300: "oklch(0.869 0.022 252.894)",
            400: "oklch(0.704 0.04 256.788)",
            500: "oklch(0.554 0.046 257.417)",
            600: "oklch(0.446 0.043 257.281)",
            700: "oklch(0.372 0.044 257.287)",
            800: "oklch(0.279 0.041 260.031)",
            900: "oklch(0.208 0.042 265.755)",
            950: "oklch(0.129 0.042 264.695)"
        },
        gray: {
            50: "oklch(0.985 0.002 247.839)",
            100: "oklch(0.967 0.003 264.542)",
            200: "oklch(0.928 0.006 264.531)",
            300: "oklch(0.872 0.01 258.338)",
            400: "oklch(0.707 0.022 261.325)",
            500: "oklch(0.551 0.027 264.364)",
            600: "oklch(0.446 0.03 256.802)",
            700: "oklch(0.373 0.034 259.733)",
            800: "oklch(0.278 0.033 256.848)",
            900: "oklch(0.21 0.034 264.665)",
            950: "oklch(0.13 0.028 261.692)"
        },
        zinc: {
            50: "oklch(0.985 0 0)",
            100: "oklch(0.967 0.001 286.375)",
            200: "oklch(0.92 0.004 286.32)",
            300: "oklch(0.871 0.006 286.286)",
            400: "oklch(0.705 0.015 286.067)",
            500: "oklch(0.552 0.016 285.938)",
            600: "oklch(0.442 0.017 285.786)",
            700: "oklch(0.37 0.013 285.805)",
            800: "oklch(0.274 0.006 286.033)",
            900: "oklch(0.21 0.006 285.885)",
            950: "oklch(0.141 0.005 285.823)"
        },
        neutral: {
            50: "oklch(0.985 0 0)",
            100: "oklch(0.97 0 0)",
            200: "oklch(0.922 0 0)",
            300: "oklch(0.87 0 0)",
            400: "oklch(0.708 0 0)",
            500: "oklch(0.556 0 0)",
            600: "oklch(0.439 0 0)",
            700: "oklch(0.371 0 0)",
            800: "oklch(0.269 0 0)",
            900: "oklch(0.205 0 0)",
            950: "oklch(0.145 0 0)"
        },
        stone: {
            50: "oklch(0.985 0.001 106.423)",
            100: "oklch(0.97 0.001 106.424)",
            200: "oklch(0.923 0.003 48.717)",
            300: "oklch(0.869 0.005 56.366)",
            400: "oklch(0.709 0.01 56.259)",
            500: "oklch(0.553 0.013 58.071)",
            600: "oklch(0.444 0.011 73.639)",
            700: "oklch(0.374 0.01 67.558)",
            800: "oklch(0.268 0.007 34.298)",
            900: "oklch(0.216 0.006 56.043)",
            950: "oklch(0.147 0.004 49.25)"
        },
        red: {
            50: "oklch(0.971 0.013 17.38)",
            100: "oklch(0.936 0.032 17.717)",
            200: "oklch(0.885 0.062 18.334)",
            300: "oklch(0.808 0.114 19.571)",
            400: "oklch(0.704 0.191 22.216)",
            500: "oklch(0.637 0.237 25.331)",
            600: "oklch(0.577 0.245 27.325)",
            700: "oklch(0.505 0.213 27.518)",
            800: "oklch(0.444 0.177 26.899)",
            900: "oklch(0.396 0.141 25.723)",
            950: "oklch(0.258 0.092 26.042)"
        },
        orange: {
            50: "oklch(0.98 0.016 73.684)",
            100: "oklch(0.954 0.038 75.164)",
            200: "oklch(0.901 0.076 70.697)",
            300: "oklch(0.837 0.128 66.29)",
            400: "oklch(0.75 0.183 55.934)",
            500: "oklch(0.705 0.213 47.604)",
            600: "oklch(0.646 0.222 41.116)",
            700: "oklch(0.553 0.195 38.402)",
            800: "oklch(0.47 0.157 37.304)",
            900: "oklch(0.408 0.123 38.172)",
            950: "oklch(0.266 0.079 36.259)"
        },
        amber: {
            50: "oklch(0.987 0.022 95.277)",
            100: "oklch(0.962 0.059 95.617)",
            200: "oklch(0.924 0.12 95.746)",
            300: "oklch(0.879 0.169 91.605)",
            400: "oklch(0.828 0.189 84.429)",
            500: "oklch(0.769 0.188 70.08)",
            600: "oklch(0.666 0.179 58.318)",
            700: "oklch(0.555 0.163 48.998)",
            800: "oklch(0.473 0.137 46.201)",
            900: "oklch(0.414 0.112 45.904)",
            950: "oklch(0.279 0.077 45.635)"
        },
        yellow: {
            50: "oklch(0.987 0.026 102.212)",
            100: "oklch(0.973 0.071 103.193)",
            200: "oklch(0.945 0.129 101.54)",
            300: "oklch(0.905 0.182 98.111)",
            400: "oklch(0.852 0.199 91.936)",
            500: "oklch(0.795 0.184 86.047)",
            600: "oklch(0.681 0.162 75.834)",
            700: "oklch(0.554 0.135 66.442)",
            800: "oklch(0.476 0.114 61.907)",
            900: "oklch(0.421 0.095 57.708)",
            950: "oklch(0.286 0.066 53.813)"
        },
        lime: {
            50: "oklch(0.986 0.031 120.757)",
            100: "oklch(0.967 0.067 122.328)",
            200: "oklch(0.938 0.127 124.321)",
            300: "oklch(0.897 0.196 126.665)",
            400: "oklch(0.841 0.238 128.85)",
            500: "oklch(0.768 0.233 130.85)",
            600: "oklch(0.648 0.2 131.684)",
            700: "oklch(0.532 0.157 131.589)",
            800: "oklch(0.453 0.124 130.933)",
            900: "oklch(0.405 0.101 131.063)",
            950: "oklch(0.274 0.072 132.109)"
        },
        green: {
            50: "oklch(0.982 0.018 155.826)",
            100: "oklch(0.962 0.044 156.743)",
            200: "oklch(0.925 0.084 155.995)",
            300: "oklch(0.871 0.15 154.449)",
            400: "oklch(0.792 0.209 151.711)",
            500: "oklch(0.723 0.219 149.579)",
            600: "oklch(0.627 0.194 149.214)",
            700: "oklch(0.527 0.154 150.069)",
            800: "oklch(0.448 0.119 151.328)",
            900: "oklch(0.393 0.095 152.535)",
            950: "oklch(0.266 0.065 152.934)"
        },
        emerald: {
            50: "oklch(0.979 0.021 166.113)",
            100: "oklch(0.95 0.052 163.051)",
            200: "oklch(0.905 0.093 164.15)",
            300: "oklch(0.845 0.143 164.978)",
            400: "oklch(0.765 0.177 163.223)",
            500: "oklch(0.696 0.17 162.48)",
            600: "oklch(0.596 0.145 163.225)",
            700: "oklch(0.508 0.118 165.612)",
            800: "oklch(0.432 0.095 166.913)",
            900: "oklch(0.378 0.077 168.94)",
            950: "oklch(0.262 0.051 172.552)"
        },
        teal: {
            50: "oklch(0.984 0.014 180.72)",
            100: "oklch(0.953 0.051 180.801)",
            200: "oklch(0.91 0.096 180.426)",
            300: "oklch(0.855 0.138 181.071)",
            400: "oklch(0.777 0.152 181.912)",
            500: "oklch(0.704 0.14 182.503)",
            600: "oklch(0.6 0.118 184.704)",
            700: "oklch(0.511 0.096 186.391)",
            800: "oklch(0.437 0.078 188.216)",
            900: "oklch(0.386 0.063 188.416)",
            950: "oklch(0.277 0.046 192.524)"
        },
        cyan: {
            50: "oklch(0.984 0.019 200.873)",
            100: "oklch(0.956 0.045 203.388)",
            200: "oklch(0.917 0.08 205.041)",
            300: "oklch(0.865 0.127 207.078)",
            400: "oklch(0.789 0.154 211.53)",
            500: "oklch(0.715 0.143 215.221)",
            600: "oklch(0.609 0.126 221.723)",
            700: "oklch(0.52 0.105 223.128)",
            800: "oklch(0.45 0.085 224.283)",
            900: "oklch(0.398 0.07 227.392)",
            950: "oklch(0.302 0.056 229.695)"
        },
        sky: {
            50: "oklch(0.977 0.013 236.62)",
            100: "oklch(0.951 0.026 236.824)",
            200: "oklch(0.901 0.058 230.902)",
            300: "oklch(0.828 0.111 230.318)",
            400: "oklch(0.746 0.16 232.661)",
            500: "oklch(0.685 0.169 237.323)",
            600: "oklch(0.588 0.158 241.966)",
            700: "oklch(0.5 0.134 242.749)",
            800: "oklch(0.443 0.11 240.79)",
            900: "oklch(0.391 0.09 240.876)",
            950: "oklch(0.293 0.066 243.157)"
        },
        blue: {
            50: "oklch(0.97 0.014 254.604)",
            100: "oklch(0.932 0.032 255.585)",
            200: "oklch(0.882 0.059 254.128)",
            300: "oklch(0.809 0.105 251.813)",
            400: "oklch(0.707 0.165 254.624)",
            500: "oklch(0.623 0.214 259.815)",
            600: "oklch(0.546 0.245 262.881)",
            700: "oklch(0.488 0.243 264.376)",
            800: "oklch(0.424 0.199 265.638)",
            900: "oklch(0.379 0.146 265.522)",
            950: "oklch(0.282 0.091 267.935)"
        },
        indigo: {
            50: "oklch(0.962 0.018 272.314)",
            100: "oklch(0.93 0.034 272.788)",
            200: "oklch(0.87 0.065 274.039)",
            300: "oklch(0.785 0.115 274.713)",
            400: "oklch(0.673 0.182 276.935)",
            500: "oklch(0.585 0.233 277.117)",
            600: "oklch(0.511 0.262 276.966)",
            700: "oklch(0.457 0.24 277.023)",
            800: "oklch(0.398 0.195 277.366)",
            900: "oklch(0.359 0.144 278.697)",
            950: "oklch(0.257 0.09 281.288)"
        },
        violet: {
            50: "oklch(0.969 0.016 293.756)",
            100: "oklch(0.943 0.029 294.588)",
            200: "oklch(0.894 0.057 293.283)",
            300: "oklch(0.811 0.111 293.571)",
            400: "oklch(0.702 0.183 293.541)",
            500: "oklch(0.606 0.25 292.717)",
            600: "oklch(0.541 0.281 293.009)",
            700: "oklch(0.491 0.27 292.581)",
            800: "oklch(0.432 0.232 292.759)",
            900: "oklch(0.38 0.189 293.745)",
            950: "oklch(0.283 0.141 291.089)"
        },
        purple: {
            50: "oklch(0.977 0.014 308.299)",
            100: "oklch(0.946 0.033 307.174)",
            200: "oklch(0.902 0.063 306.703)",
            300: "oklch(0.827 0.119 306.383)",
            400: "oklch(0.714 0.203 305.504)",
            500: "oklch(0.627 0.265 303.9)",
            600: "oklch(0.558 0.288 302.321)",
            700: "oklch(0.496 0.265 301.924)",
            800: "oklch(0.438 0.218 303.724)",
            900: "oklch(0.381 0.176 304.987)",
            950: "oklch(0.291 0.149 302.717)"
        },
        fuchsia: {
            50: "oklch(0.977 0.017 320.058)",
            100: "oklch(0.952 0.037 318.852)",
            200: "oklch(0.903 0.076 319.62)",
            300: "oklch(0.833 0.145 321.434)",
            400: "oklch(0.74 0.238 322.16)",
            500: "oklch(0.667 0.295 322.15)",
            600: "oklch(0.591 0.293 322.896)",
            700: "oklch(0.518 0.253 323.949)",
            800: "oklch(0.452 0.211 324.591)",
            900: "oklch(0.401 0.17 325.612)",
            950: "oklch(0.293 0.136 325.661)"
        },
        pink: {
            50: "oklch(0.971 0.014 343.198)",
            100: "oklch(0.948 0.028 342.258)",
            200: "oklch(0.899 0.061 343.231)",
            300: "oklch(0.823 0.12 346.018)",
            400: "oklch(0.718 0.202 349.761)",
            500: "oklch(0.656 0.241 354.308)",
            600: "oklch(0.592 0.249 0.584)",
            700: "oklch(0.525 0.223 3.958)",
            800: "oklch(0.459 0.187 3.815)",
            900: "oklch(0.408 0.153 2.432)",
            950: "oklch(0.284 0.109 3.907)"
        },
        rose: {
            50: "oklch(0.969 0.015 12.422)",
            100: "oklch(0.941 0.03 12.58)",
            200: "oklch(0.892 0.058 10.001)",
            300: "oklch(0.81 0.117 11.638)",
            400: "oklch(0.712 0.194 13.428)",
            500: "oklch(0.645 0.246 16.439)",
            600: "oklch(0.586 0.253 17.585)",
            700: "oklch(0.514 0.222 16.935)",
            800: "oklch(0.455 0.188 13.697)",
            900: "oklch(0.41 0.159 10.272)",
            950: "oklch(0.271 0.105 12.094)"
        }
    };

    function bt(e) {
        return {__BARE_VALUE__: e}
    }

    var wt = bt((e => {
        if (ae(e.value)) return e.value
    })), kt = bt((e => {
        if (ae(e.value)) return `${e.value}%`
    })), yt = bt((e => {
        if (ae(e.value)) return `${e.value}px`
    })), xt = bt((e => {
        if (ae(e.value)) return `${e.value}ms`
    })), $t = bt((e => {
        if (ae(e.value)) return `${e.value}deg`
    })), At = bt((e => {
        if (null === e.fraction) return;
        let [t, r] = B(e.fraction, "/");
        return ae(t) && ae(r) ? e.fraction : void 0
    })), zt = bt((e => {
        if (ae(Number(e.value))) return `repeat(${e.value}, minmax(0, 1fr))`
    })), Ct = {
        accentColor: ({theme: e}) => e("colors"),
        animation: {
            none: "none",
            spin: "spin 1s linear infinite",
            ping: "ping 1s cubic-bezier(0, 0, 0.2, 1) infinite",
            pulse: "pulse 2s cubic-bezier(0.4, 0, 0.6, 1) infinite",
            bounce: "bounce 1s infinite"
        },
        aria: {
            busy: 'busy="true"',
            checked: 'checked="true"',
            disabled: 'disabled="true"',
            expanded: 'expanded="true"',
            hidden: 'hidden="true"',
            pressed: 'pressed="true"',
            readonly: 'readonly="true"',
            required: 'required="true"',
            selected: 'selected="true"'
        },
        aspectRatio: {auto: "auto", square: "1 / 1", video: "16 / 9", ...At},
        backdropBlur: ({theme: e}) => e("blur"),
        backdropBrightness: ({theme: e}) => ({...e("brightness"), ...kt}),
        backdropContrast: ({theme: e}) => ({...e("contrast"), ...kt}),
        backdropGrayscale: ({theme: e}) => ({...e("grayscale"), ...kt}),
        backdropHueRotate: ({theme: e}) => ({...e("hueRotate"), ...$t}),
        backdropInvert: ({theme: e}) => ({...e("invert"), ...kt}),
        backdropOpacity: ({theme: e}) => ({...e("opacity"), ...kt}),
        backdropSaturate: ({theme: e}) => ({...e("saturate"), ...kt}),
        backdropSepia: ({theme: e}) => ({...e("sepia"), ...kt}),
        backgroundColor: ({theme: e}) => e("colors"),
        backgroundImage: {
            none: "none",
            "gradient-to-t": "linear-gradient(to top, var(--tw-gradient-stops))",
            "gradient-to-tr": "linear-gradient(to top right, var(--tw-gradient-stops))",
            "gradient-to-r": "linear-gradient(to right, var(--tw-gradient-stops))",
            "gradient-to-br": "linear-gradient(to bottom right, var(--tw-gradient-stops))",
            "gradient-to-b": "linear-gradient(to bottom, var(--tw-gradient-stops))",
            "gradient-to-bl": "linear-gradient(to bottom left, var(--tw-gradient-stops))",
            "gradient-to-l": "linear-gradient(to left, var(--tw-gradient-stops))",
            "gradient-to-tl": "linear-gradient(to top left, var(--tw-gradient-stops))"
        },
        backgroundOpacity: ({theme: e}) => e("opacity"),
        backgroundPosition: {
            bottom: "bottom",
            center: "center",
            left: "left",
            "left-bottom": "left bottom",
            "left-top": "left top",
            right: "right",
            "right-bottom": "right bottom",
            "right-top": "right top",
            top: "top"
        },
        backgroundSize: {auto: "auto", cover: "cover", contain: "contain"},
        blur: {
            0: "0",
            none: "",
            sm: "4px",
            DEFAULT: "8px",
            md: "12px",
            lg: "16px",
            xl: "24px",
            "2xl": "40px",
            "3xl": "64px"
        },
        borderColor: ({theme: e}) => ({DEFAULT: "currentColor", ...e("colors")}),
        borderOpacity: ({theme: e}) => e("opacity"),
        borderRadius: {
            none: "0px",
            sm: "0.125rem",
            DEFAULT: "0.25rem",
            md: "0.375rem",
            lg: "0.5rem",
            xl: "0.75rem",
            "2xl": "1rem",
            "3xl": "1.5rem",
            full: "9999px"
        },
        borderSpacing: ({theme: e}) => e("spacing"),
        borderWidth: {DEFAULT: "1px", 0: "0px", 2: "2px", 4: "4px", 8: "8px", ...yt},
        boxShadow: {
            sm: "0 1px 2px 0 rgb(0 0 0 / 0.05)",
            DEFAULT: "0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1)",
            md: "0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1)",
            lg: "0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1)",
            xl: "0 20px 25px -5px rgb(0 0 0 / 0.1), 0 8px 10px -6px rgb(0 0 0 / 0.1)",
            "2xl": "0 25px 50px -12px rgb(0 0 0 / 0.25)",
            inner: "inset 0 2px 4px 0 rgb(0 0 0 / 0.05)",
            none: "none"
        },
        boxShadowColor: ({theme: e}) => e("colors"),
        brightness: {
            0: "0",
            50: ".5",
            75: ".75",
            90: ".9",
            95: ".95",
            100: "1",
            105: "1.05",
            110: "1.1",
            125: "1.25",
            150: "1.5",
            200: "2", ...kt
        },
        caretColor: ({theme: e}) => e("colors"),
        colors: () => ({...vt}),
        columns: {
            auto: "auto",
            1: "1",
            2: "2",
            3: "3",
            4: "4",
            5: "5",
            6: "6",
            7: "7",
            8: "8",
            9: "9",
            10: "10",
            11: "11",
            12: "12",
            "3xs": "16rem",
            "2xs": "18rem",
            xs: "20rem",
            sm: "24rem",
            md: "28rem",
            lg: "32rem",
            xl: "36rem",
            "2xl": "42rem",
            "3xl": "48rem",
            "4xl": "56rem",
            "5xl": "64rem",
            "6xl": "72rem",
            "7xl": "80rem", ...wt
        },
        container: {},
        content: {none: "none"},
        contrast: {0: "0", 50: ".5", 75: ".75", 100: "1", 125: "1.25", 150: "1.5", 200: "2", ...kt},
        cursor: {
            auto: "auto",
            default: "default",
            pointer: "pointer",
            wait: "wait",
            text: "text",
            move: "move",
            help: "help",
            "not-allowed": "not-allowed",
            none: "none",
            "context-menu": "context-menu",
            progress: "progress",
            cell: "cell",
            crosshair: "crosshair",
            "vertical-text": "vertical-text",
            alias: "alias",
            copy: "copy",
            "no-drop": "no-drop",
            grab: "grab",
            grabbing: "grabbing",
            "all-scroll": "all-scroll",
            "col-resize": "col-resize",
            "row-resize": "row-resize",
            "n-resize": "n-resize",
            "e-resize": "e-resize",
            "s-resize": "s-resize",
            "w-resize": "w-resize",
            "ne-resize": "ne-resize",
            "nw-resize": "nw-resize",
            "se-resize": "se-resize",
            "sw-resize": "sw-resize",
            "ew-resize": "ew-resize",
            "ns-resize": "ns-resize",
            "nesw-resize": "nesw-resize",
            "nwse-resize": "nwse-resize",
            "zoom-in": "zoom-in",
            "zoom-out": "zoom-out"
        },
        divideColor: ({theme: e}) => e("borderColor"),
        divideOpacity: ({theme: e}) => e("borderOpacity"),
        divideWidth: ({theme: e}) => ({...e("borderWidth"), ...yt}),
        dropShadow: {
            sm: "0 1px 1px rgb(0 0 0 / 0.05)",
            DEFAULT: ["0 1px 2px rgb(0 0 0 / 0.1)", "0 1px 1px rgb(0 0 0 / 0.06)"],
            md: ["0 4px 3px rgb(0 0 0 / 0.07)", "0 2px 2px rgb(0 0 0 / 0.06)"],
            lg: ["0 10px 8px rgb(0 0 0 / 0.04)", "0 4px 3px rgb(0 0 0 / 0.1)"],
            xl: ["0 20px 13px rgb(0 0 0 / 0.03)", "0 8px 5px rgb(0 0 0 / 0.08)"],
            "2xl": "0 25px 25px rgb(0 0 0 / 0.15)",
            none: "0 0 #0000"
        },
        fill: ({theme: e}) => e("colors"),
        flex: {1: "1 1 0%", auto: "1 1 auto", initial: "0 1 auto", none: "none"},
        flexBasis: ({theme: e}) => ({
            auto: "auto",
            "1/2": "50%",
            "1/3": "33.333333%",
            "2/3": "66.666667%",
            "1/4": "25%",
            "2/4": "50%",
            "3/4": "75%",
            "1/5": "20%",
            "2/5": "40%",
            "3/5": "60%",
            "4/5": "80%",
            "1/6": "16.666667%",
            "2/6": "33.333333%",
            "3/6": "50%",
            "4/6": "66.666667%",
            "5/6": "83.333333%",
            "1/12": "8.333333%",
            "2/12": "16.666667%",
            "3/12": "25%",
            "4/12": "33.333333%",
            "5/12": "41.666667%",
            "6/12": "50%",
            "7/12": "58.333333%",
            "8/12": "66.666667%",
            "9/12": "75%",
            "10/12": "83.333333%",
            "11/12": "91.666667%",
            full: "100%", ...e("spacing")
        }),
        flexGrow: {0: "0", DEFAULT: "1", ...wt},
        flexShrink: {0: "0", DEFAULT: "1", ...wt},
        fontFamily: {
            sans: ["ui-sans-serif", "system-ui", "sans-serif", '"Apple Color Emoji"', '"Segoe UI Emoji"', '"Segoe UI Symbol"', '"Noto Color Emoji"'],
            serif: ["ui-serif", "Georgia", "Cambria", '"Times New Roman"', "Times", "serif"],
            mono: ["ui-monospace", "SFMono-Regular", "Menlo", "Monaco", "Consolas", '"Liberation Mono"', '"Courier New"', "monospace"]
        },
        fontSize: {
            xs: ["0.75rem", {lineHeight: "1rem"}],
            sm: ["0.875rem", {lineHeight: "1.25rem"}],
            base: ["1rem", {lineHeight: "1.5rem"}],
            lg: ["1.125rem", {lineHeight: "1.75rem"}],
            xl: ["1.25rem", {lineHeight: "1.75rem"}],
            "2xl": ["1.5rem", {lineHeight: "2rem"}],
            "3xl": ["1.875rem", {lineHeight: "2.25rem"}],
            "4xl": ["2.25rem", {lineHeight: "2.5rem"}],
            "5xl": ["3rem", {lineHeight: "1"}],
            "6xl": ["3.75rem", {lineHeight: "1"}],
            "7xl": ["4.5rem", {lineHeight: "1"}],
            "8xl": ["6rem", {lineHeight: "1"}],
            "9xl": ["8rem", {lineHeight: "1"}]
        },
        fontWeight: {
            thin: "100",
            extralight: "200",
            light: "300",
            normal: "400",
            medium: "500",
            semibold: "600",
            bold: "700",
            extrabold: "800",
            black: "900"
        },
        gap: ({theme: e}) => e("spacing"),
        gradientColorStops: ({theme: e}) => e("colors"),
        gradientColorStopPositions: {
            "0%": "0%",
            "5%": "5%",
            "10%": "10%",
            "15%": "15%",
            "20%": "20%",
            "25%": "25%",
            "30%": "30%",
            "35%": "35%",
            "40%": "40%",
            "45%": "45%",
            "50%": "50%",
            "55%": "55%",
            "60%": "60%",
            "65%": "65%",
            "70%": "70%",
            "75%": "75%",
            "80%": "80%",
            "85%": "85%",
            "90%": "90%",
            "95%": "95%",
            "100%": "100%", ...kt
        },
        grayscale: {0: "0", DEFAULT: "100%", ...kt},
        gridAutoColumns: {auto: "auto", min: "min-content", max: "max-content", fr: "minmax(0, 1fr)"},
        gridAutoRows: {auto: "auto", min: "min-content", max: "max-content", fr: "minmax(0, 1fr)"},
        gridColumn: {
            auto: "auto",
            "span-1": "span 1 / span 1",
            "span-2": "span 2 / span 2",
            "span-3": "span 3 / span 3",
            "span-4": "span 4 / span 4",
            "span-5": "span 5 / span 5",
            "span-6": "span 6 / span 6",
            "span-7": "span 7 / span 7",
            "span-8": "span 8 / span 8",
            "span-9": "span 9 / span 9",
            "span-10": "span 10 / span 10",
            "span-11": "span 11 / span 11",
            "span-12": "span 12 / span 12",
            "span-full": "1 / -1"
        },
        gridColumnEnd: {
            auto: "auto",
            1: "1",
            2: "2",
            3: "3",
            4: "4",
            5: "5",
            6: "6",
            7: "7",
            8: "8",
            9: "9",
            10: "10",
            11: "11",
            12: "12",
            13: "13", ...wt
        },
        gridColumnStart: {
            auto: "auto",
            1: "1",
            2: "2",
            3: "3",
            4: "4",
            5: "5",
            6: "6",
            7: "7",
            8: "8",
            9: "9",
            10: "10",
            11: "11",
            12: "12",
            13: "13", ...wt
        },
        gridRow: {
            auto: "auto",
            "span-1": "span 1 / span 1",
            "span-2": "span 2 / span 2",
            "span-3": "span 3 / span 3",
            "span-4": "span 4 / span 4",
            "span-5": "span 5 / span 5",
            "span-6": "span 6 / span 6",
            "span-7": "span 7 / span 7",
            "span-8": "span 8 / span 8",
            "span-9": "span 9 / span 9",
            "span-10": "span 10 / span 10",
            "span-11": "span 11 / span 11",
            "span-12": "span 12 / span 12",
            "span-full": "1 / -1"
        },
        gridRowEnd: {
            auto: "auto",
            1: "1",
            2: "2",
            3: "3",
            4: "4",
            5: "5",
            6: "6",
            7: "7",
            8: "8",
            9: "9",
            10: "10",
            11: "11",
            12: "12",
            13: "13", ...wt
        },
        gridRowStart: {
            auto: "auto",
            1: "1",
            2: "2",
            3: "3",
            4: "4",
            5: "5",
            6: "6",
            7: "7",
            8: "8",
            9: "9",
            10: "10",
            11: "11",
            12: "12",
            13: "13", ...wt
        },
        gridTemplateColumns: {
            none: "none",
            subgrid: "subgrid",
            1: "repeat(1, minmax(0, 1fr))",
            2: "repeat(2, minmax(0, 1fr))",
            3: "repeat(3, minmax(0, 1fr))",
            4: "repeat(4, minmax(0, 1fr))",
            5: "repeat(5, minmax(0, 1fr))",
            6: "repeat(6, minmax(0, 1fr))",
            7: "repeat(7, minmax(0, 1fr))",
            8: "repeat(8, minmax(0, 1fr))",
            9: "repeat(9, minmax(0, 1fr))",
            10: "repeat(10, minmax(0, 1fr))",
            11: "repeat(11, minmax(0, 1fr))",
            12: "repeat(12, minmax(0, 1fr))", ...zt
        },
        gridTemplateRows: {
            none: "none",
            subgrid: "subgrid",
            1: "repeat(1, minmax(0, 1fr))",
            2: "repeat(2, minmax(0, 1fr))",
            3: "repeat(3, minmax(0, 1fr))",
            4: "repeat(4, minmax(0, 1fr))",
            5: "repeat(5, minmax(0, 1fr))",
            6: "repeat(6, minmax(0, 1fr))",
            7: "repeat(7, minmax(0, 1fr))",
            8: "repeat(8, minmax(0, 1fr))",
            9: "repeat(9, minmax(0, 1fr))",
            10: "repeat(10, minmax(0, 1fr))",
            11: "repeat(11, minmax(0, 1fr))",
            12: "repeat(12, minmax(0, 1fr))", ...zt
        },
        height: ({theme: e}) => ({
            auto: "auto",
            "1/2": "50%",
            "1/3": "33.333333%",
            "2/3": "66.666667%",
            "1/4": "25%",
            "2/4": "50%",
            "3/4": "75%",
            "1/5": "20%",
            "2/5": "40%",
            "3/5": "60%",
            "4/5": "80%",
            "1/6": "16.666667%",
            "2/6": "33.333333%",
            "3/6": "50%",
            "4/6": "66.666667%",
            "5/6": "83.333333%",
            full: "100%",
            screen: "100vh",
            svh: "100svh",
            lvh: "100lvh",
            dvh: "100dvh",
            min: "min-content",
            max: "max-content",
            fit: "fit-content", ...e("spacing")
        }),
        hueRotate: {0: "0deg", 15: "15deg", 30: "30deg", 60: "60deg", 90: "90deg", 180: "180deg", ...$t},
        inset: ({theme: e}) => ({
            auto: "auto",
            "1/2": "50%",
            "1/3": "33.333333%",
            "2/3": "66.666667%",
            "1/4": "25%",
            "2/4": "50%",
            "3/4": "75%",
            full: "100%", ...e("spacing")
        }),
        invert: {0: "0", DEFAULT: "100%", ...kt},
        keyframes: {
            spin: {to: {transform: "rotate(360deg)"}},
            ping: {"75%, 100%": {transform: "scale(2)", opacity: "0"}},
            pulse: {"50%": {opacity: ".5"}},
            bounce: {
                "0%, 100%": {transform: "translateY(-25%)", animationTimingFunction: "cubic-bezier(0.8,0,1,1)"},
                "50%": {transform: "none", animationTimingFunction: "cubic-bezier(0,0,0.2,1)"}
            }
        },
        letterSpacing: {
            tighter: "-0.05em",
            tight: "-0.025em",
            normal: "0em",
            wide: "0.025em",
            wider: "0.05em",
            widest: "0.1em"
        },
        lineHeight: {
            none: "1",
            tight: "1.25",
            snug: "1.375",
            normal: "1.5",
            relaxed: "1.625",
            loose: "2",
            3: ".75rem",
            4: "1rem",
            5: "1.25rem",
            6: "1.5rem",
            7: "1.75rem",
            8: "2rem",
            9: "2.25rem",
            10: "2.5rem"
        },
        listStyleType: {none: "none", disc: "disc", decimal: "decimal"},
        listStyleImage: {none: "none"},
        margin: ({theme: e}) => ({auto: "auto", ...e("spacing")}),
        lineClamp: {1: "1", 2: "2", 3: "3", 4: "4", 5: "5", 6: "6", ...wt},
        maxHeight: ({theme: e}) => ({
            none: "none",
            full: "100%",
            screen: "100vh",
            svh: "100svh",
            lvh: "100lvh",
            dvh: "100dvh",
            min: "min-content",
            max: "max-content",
            fit: "fit-content", ...e("spacing")
        }),
        maxWidth: ({theme: e}) => ({
            none: "none",
            xs: "20rem",
            sm: "24rem",
            md: "28rem",
            lg: "32rem",
            xl: "36rem",
            "2xl": "42rem",
            "3xl": "48rem",
            "4xl": "56rem",
            "5xl": "64rem",
            "6xl": "72rem",
            "7xl": "80rem",
            full: "100%",
            min: "min-content",
            max: "max-content",
            fit: "fit-content",
            prose: "65ch", ...e("spacing")
        }),
        minHeight: ({theme: e}) => ({
            full: "100%",
            screen: "100vh",
            svh: "100svh",
            lvh: "100lvh",
            dvh: "100dvh",
            min: "min-content",
            max: "max-content",
            fit: "fit-content", ...e("spacing")
        }),
        minWidth: ({theme: e}) => ({
            full: "100%",
            min: "min-content",
            max: "max-content",
            fit: "fit-content", ...e("spacing")
        }),
        objectPosition: {
            bottom: "bottom",
            center: "center",
            left: "left",
            "left-bottom": "left bottom",
            "left-top": "left top",
            right: "right",
            "right-bottom": "right bottom",
            "right-top": "right top",
            top: "top"
        },
        opacity: {
            0: "0",
            5: "0.05",
            10: "0.1",
            15: "0.15",
            20: "0.2",
            25: "0.25",
            30: "0.3",
            35: "0.35",
            40: "0.4",
            45: "0.45",
            50: "0.5",
            55: "0.55",
            60: "0.6",
            65: "0.65",
            70: "0.7",
            75: "0.75",
            80: "0.8",
            85: "0.85",
            90: "0.9",
            95: "0.95",
            100: "1", ...kt
        },
        order: {
            first: "-9999",
            last: "9999",
            none: "0",
            1: "1",
            2: "2",
            3: "3",
            4: "4",
            5: "5",
            6: "6",
            7: "7",
            8: "8",
            9: "9",
            10: "10",
            11: "11",
            12: "12", ...wt
        },
        outlineColor: ({theme: e}) => e("colors"),
        outlineOffset: {0: "0px", 1: "1px", 2: "2px", 4: "4px", 8: "8px", ...yt},
        outlineWidth: {0: "0px", 1: "1px", 2: "2px", 4: "4px", 8: "8px", ...yt},
        padding: ({theme: e}) => e("spacing"),
        placeholderColor: ({theme: e}) => e("colors"),
        placeholderOpacity: ({theme: e}) => e("opacity"),
        ringColor: ({theme: e}) => ({DEFAULT: "currentColor", ...e("colors")}),
        ringOffsetColor: ({theme: e}) => e("colors"),
        ringOffsetWidth: {0: "0px", 1: "1px", 2: "2px", 4: "4px", 8: "8px", ...yt},
        ringOpacity: ({theme: e}) => ({DEFAULT: "0.5", ...e("opacity")}),
        ringWidth: {DEFAULT: "3px", 0: "0px", 1: "1px", 2: "2px", 4: "4px", 8: "8px", ...yt},
        rotate: {
            0: "0deg",
            1: "1deg",
            2: "2deg",
            3: "3deg",
            6: "6deg",
            12: "12deg",
            45: "45deg",
            90: "90deg",
            180: "180deg", ...$t
        },
        saturate: {0: "0", 50: ".5", 100: "1", 150: "1.5", 200: "2", ...kt},
        scale: {
            0: "0",
            50: ".5",
            75: ".75",
            90: ".9",
            95: ".95",
            100: "1",
            105: "1.05",
            110: "1.1",
            125: "1.25",
            150: "1.5", ...kt
        },
        screens: {sm: "40rem", md: "48rem", lg: "64rem", xl: "80rem", "2xl": "96rem"},
        scrollMargin: ({theme: e}) => e("spacing"),
        scrollPadding: ({theme: e}) => e("spacing"),
        sepia: {0: "0", DEFAULT: "100%", ...kt},
        skew: {0: "0deg", 1: "1deg", 2: "2deg", 3: "3deg", 6: "6deg", 12: "12deg", ...$t},
        space: ({theme: e}) => e("spacing"),
        spacing: {
            px: "1px",
            0: "0px",
            .5: "0.125rem",
            1: "0.25rem",
            1.5: "0.375rem",
            2: "0.5rem",
            2.5: "0.625rem",
            3: "0.75rem",
            3.5: "0.875rem",
            4: "1rem",
            5: "1.25rem",
            6: "1.5rem",
            7: "1.75rem",
            8: "2rem",
            9: "2.25rem",
            10: "2.5rem",
            11: "2.75rem",
            12: "3rem",
            14: "3.5rem",
            16: "4rem",
            20: "5rem",
            24: "6rem",
            28: "7rem",
            32: "8rem",
            36: "9rem",
            40: "10rem",
            44: "11rem",
            48: "12rem",
            52: "13rem",
            56: "14rem",
            60: "15rem",
            64: "16rem",
            72: "18rem",
            80: "20rem",
            96: "24rem"
        },
        stroke: ({theme: e}) => ({none: "none", ...e("colors")}),
        strokeWidth: {0: "0", 1: "1", 2: "2", ...wt},
        supports: {},
        data: {},
        textColor: ({theme: e}) => e("colors"),
        textDecorationColor: ({theme: e}) => e("colors"),
        textDecorationThickness: {
            auto: "auto",
            "from-font": "from-font",
            0: "0px",
            1: "1px",
            2: "2px",
            4: "4px",
            8: "8px", ...yt
        },
        textIndent: ({theme: e}) => e("spacing"),
        textOpacity: ({theme: e}) => e("opacity"),
        textUnderlineOffset: {auto: "auto", 0: "0px", 1: "1px", 2: "2px", 4: "4px", 8: "8px", ...yt},
        transformOrigin: {
            center: "center",
            top: "top",
            "top-right": "top right",
            right: "right",
            "bottom-right": "bottom right",
            bottom: "bottom",
            "bottom-left": "bottom left",
            left: "left",
            "top-left": "top left"
        },
        transitionDelay: {
            0: "0s",
            75: "75ms",
            100: "100ms",
            150: "150ms",
            200: "200ms",
            300: "300ms",
            500: "500ms",
            700: "700ms",
            1e3: "1000ms", ...xt
        },
        transitionDuration: {
            DEFAULT: "150ms",
            0: "0s",
            75: "75ms",
            100: "100ms",
            150: "150ms",
            200: "200ms",
            300: "300ms",
            500: "500ms",
            700: "700ms",
            1e3: "1000ms", ...xt
        },
        transitionProperty: {
            none: "none",
            all: "all",
            DEFAULT: "color, background-color, border-color, outline-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter",
            colors: "color, background-color, border-color, outline-color, text-decoration-color, fill, stroke",
            opacity: "opacity",
            shadow: "box-shadow",
            transform: "transform"
        },
        transitionTimingFunction: {
            DEFAULT: "cubic-bezier(0.4, 0, 0.2, 1)",
            linear: "linear",
            in: "cubic-bezier(0.4, 0, 1, 1)",
            out: "cubic-bezier(0, 0, 0.2, 1)",
            "in-out": "cubic-bezier(0.4, 0, 0.2, 1)"
        },
        translate: ({theme: e}) => ({
            "1/2": "50%",
            "1/3": "33.333333%",
            "2/3": "66.666667%",
            "1/4": "25%",
            "2/4": "50%",
            "3/4": "75%",
            full: "100%", ...e("spacing")
        }),
        size: ({theme: e}) => ({
            auto: "auto",
            "1/2": "50%",
            "1/3": "33.333333%",
            "2/3": "66.666667%",
            "1/4": "25%",
            "2/4": "50%",
            "3/4": "75%",
            "1/5": "20%",
            "2/5": "40%",
            "3/5": "60%",
            "4/5": "80%",
            "1/6": "16.666667%",
            "2/6": "33.333333%",
            "3/6": "50%",
            "4/6": "66.666667%",
            "5/6": "83.333333%",
            "1/12": "8.333333%",
            "2/12": "16.666667%",
            "3/12": "25%",
            "4/12": "33.333333%",
            "5/12": "41.666667%",
            "6/12": "50%",
            "7/12": "58.333333%",
            "8/12": "66.666667%",
            "9/12": "75%",
            "10/12": "83.333333%",
            "11/12": "91.666667%",
            full: "100%",
            min: "min-content",
            max: "max-content",
            fit: "fit-content", ...e("spacing")
        }),
        width: ({theme: e}) => ({
            auto: "auto",
            "1/2": "50%",
            "1/3": "33.333333%",
            "2/3": "66.666667%",
            "1/4": "25%",
            "2/4": "50%",
            "3/4": "75%",
            "1/5": "20%",
            "2/5": "40%",
            "3/5": "60%",
            "4/5": "80%",
            "1/6": "16.666667%",
            "2/6": "33.333333%",
            "3/6": "50%",
            "4/6": "66.666667%",
            "5/6": "83.333333%",
            "1/12": "8.333333%",
            "2/12": "16.666667%",
            "3/12": "25%",
            "4/12": "33.333333%",
            "5/12": "41.666667%",
            "6/12": "50%",
            "7/12": "58.333333%",
            "8/12": "66.666667%",
            "9/12": "75%",
            "10/12": "83.333333%",
            "11/12": "91.666667%",
            full: "100%",
            screen: "100vw",
            svw: "100svw",
            lvw: "100lvw",
            dvw: "100dvw",
            min: "min-content",
            max: "max-content",
            fit: "fit-content", ...e("spacing")
        }),
        willChange: {auto: "auto", scroll: "scroll-position", contents: "contents", transform: "transform"},
        zIndex: {auto: "auto", 0: "0", 10: "10", 20: "20", 30: "30", 40: "40", 50: "50", ...wt}
    };

    function Tt(e) {
        return {
            theme: {
                ...Ct,
                colors: ({theme: e}) => e("color", {}),
                extend: {
                    fontSize: ({theme: e}) => ({...e("text", {})}),
                    boxShadow: ({theme: e}) => ({...e("shadow", {})}),
                    animation: ({theme: e}) => ({...e("animate", {})}),
                    aspectRatio: ({theme: e}) => ({...e("aspect", {})}),
                    borderRadius: ({theme: e}) => ({...e("radius", {})}),
                    screens: ({theme: e}) => ({...e("breakpoint", {})}),
                    letterSpacing: ({theme: e}) => ({...e("tracking", {})}),
                    lineHeight: ({theme: e}) => ({...e("leading", {})}),
                    transitionDuration: {DEFAULT: e.get(["--default-transition-duration"]) ?? null},
                    transitionTimingFunction: {DEFAULT: e.get(["--default-transition-timing-function"]) ?? null},
                    maxWidth: ({theme: e}) => ({...e("container", {})})
                }
            }
        }
    }

    var jt = {
        blocklist: [],
        future: {},
        prefix: "",
        important: !1,
        darkMode: null,
        theme: {},
        plugins: [],
        content: {files: []}
    };

    function Kt(e, t) {
        let r = {
            design: e,
            configs: [],
            plugins: [],
            content: {files: []},
            theme: {},
            extend: {},
            result: structuredClone(jt)
        };
        for (let e of t) Et(r, e);
        for (let e of r.configs) "darkMode" in e && void 0 !== e.darkMode && (r.result.darkMode = e.darkMode ?? null), "prefix" in e && void 0 !== e.prefix && (r.result.prefix = e.prefix ?? ""), "blocklist" in e && void 0 !== e.blocklist && (r.result.blocklist = e.blocklist ?? []), "important" in e && void 0 !== e.important && (r.result.important = e.important ?? !1);
        let n = function (e) {
            let t = new Set, r = et(e.design, (() => e.theme), o), n = Object.assign(r, {theme: r, colors: vt});

            function o(e) {
                return "function" == typeof e ? e(n) ?? null : e ?? null
            }

            for (let r of e.configs) {
                let n = r.theme ?? {}, o = n.extend ?? {};
                for (let e in n) "extend" !== e && t.add(e);
                Object.assign(e.theme, n);
                for (let t in o) e.extend[t] ??= [], e.extend[t].push(o[t])
            }
            delete e.theme.extend;
            for (let t in e.extend) {
                let r = [e.theme[t], ...e.extend[t]];
                e.theme[t] = () => Qe({}, r.map(o), St)
            }
            for (let t in e.theme) e.theme[t] = o(e.theme[t]);
            if (e.theme.screens && "object" == typeof e.theme.screens) for (let t of Object.keys(e.theme.screens)) {
                let r = e.theme.screens[t];
                r && "object" == typeof r && ("raw" in r || "max" in r || "min" in r && (e.theme.screens[t] = r.min))
            }
            return t
        }(r);
        return {
            resolvedConfig: {...r.result, content: r.content, theme: r.theme, plugins: r.plugins},
            replacedThemeKeys: n
        }
    }

    function St(e, t) {
        return Array.isArray(e) && Je(e[0]) ? e.concat(t) : Array.isArray(t) && Je(t[0]) && Je(e) ? [e, ...t] : Array.isArray(t) ? t : void 0
    }

    function Et(e, {config: t, base: r, path: n, reference: o}) {
        let i = [];
        for (let e of t.plugins ?? []) "__isOptionsFunction" in e ? i.push({
            ...e(),
            reference: o
        }) : "handler" in e ? i.push({...e, reference: o}) : i.push({handler: e, reference: o});
        if (Array.isArray(t.presets) && 0 === t.presets.length) throw new Error("Error in the config file/plugin/preset. An empty preset (`preset: []`) is not currently supported.");
        for (let i of t.presets ?? []) Et(e, {path: n, base: r, config: i, reference: o});
        for (let t of i) e.plugins.push(t), t.config && Et(e, {
            path: n,
            base: r,
            config: t.config,
            reference: !!t.reference
        });
        let l = t.content ?? [], a = Array.isArray(l) ? l : l.files;
        for (let t of a) e.content.files.push("object" == typeof t ? t : {base: r, pattern: t});
        e.configs.push(t)
    }

    function Vt(e, t) {
        let r = e.theme.container || {};
        if ("object" != typeof r || null === r) return;
        let n = function ({center: e, padding: t, screens: r}, n) {
            let o = [], i = null;
            if (e && o.push(y("margin-inline", "auto")), ("string" == typeof t || "object" == typeof t && null !== t && "DEFAULT" in t) && o.push(y("padding-inline", "string" == typeof t ? t : t.DEFAULT)), "object" == typeof r && null !== r) {
                i = new Map;
                let e = Array.from(n.theme.namespace("--breakpoint").entries());
                if (e.sort(((e, t) => R(e[1], t[1], "asc"))), e.length > 0) {
                    let [t] = e[0];
                    o.push(w("@media", `(width >= --theme(--breakpoint-${t}))`, [y("max-width", "none")]))
                }
                for (let [e, t] of Object.entries(r)) {
                    if ("object" == typeof t) {
                        if (!("min" in t)) continue;
                        t = t.min
                    }
                    i.set(e, w("@media", `(width >= ${t})`, [y("max-width", t)]))
                }
            }
            if ("object" == typeof t && null !== t) {
                let e = Object.entries(t).filter((([e]) => "DEFAULT" !== e)).map((([e, t]) => [e, n.theme.resolveValue(e, ["--breakpoint"]), t])).filter(Boolean);
                e.sort(((e, t) => R(e[1], t[1], "asc")));
                for (let [t, , r] of e) if (i && i.has(t)) i.get(t).nodes.push(y("padding-inline", r)); else {
                    if (i) continue;
                    o.push(w("@media", `(width >= theme(--breakpoint-${t}))`, [y("padding-inline", r)]))
                }
            }
            if (i) for (let [, e] of i) o.push(e);
            return o
        }(r, t);
        0 !== n.length && t.utilities.static("container", (() => structuredClone(n)))
    }

    function Nt({addVariant: e, config: t}) {
        let r = t("darkMode", null), [n, o = ".dark"] = Array.isArray(r) ? r : [r];
        if ("variant" === n) {
            let e;
            if (Array.isArray(o) || "function" == typeof o ? e = o : "string" == typeof o && (e = [o]), Array.isArray(e)) for (let t of e) ".dark" === t ? (n = !1, console.warn('When using `variant` for `darkMode`, you must provide a selector.\nExample: `darkMode: ["variant", ".your-selector &"]`')) : t.includes("&") || (n = !1, console.warn('When using `variant` for `darkMode`, your selector must contain `&`.\nExample `darkMode: ["variant", ".your-selector &"]`'));
            o = e
        }
        null === n || ("selector" === n ? e("dark", `&:where(${o}, ${o} *)`) : "media" === n ? e("dark", "@media (prefers-color-scheme: dark)") : "variant" === n ? e("dark", o) : "class" === n && e("dark", `&:is(${o} *)`))
    }

    function Ot(e) {
        return (Array.isArray(e) ? e : [e]).map((e => "string" == typeof e ? {min: e} : e && "object" == typeof e ? e : null)).map((e => {
            if (null === e) return null;
            if ("raw" in e) return e.raw;
            let t = "";
            return void 0 !== e.max && (t += `${e.max} >= `), t += "width", void 0 !== e.min && (t += ` >= ${e.min}`), `(${t})`
        })).filter(Boolean).join(", ")
    }

    var Ft = /^[a-z]+$/;

    async function Ut({designSystem: e, base: t, ast: r, loadModule: n, globs: o}) {
        let i = 0, l = [], a = [];
        z(r, ((e, {parent: t, replaceWith: r, context: n}) => {
            if ("at-rule" === e.kind) {
                if ("@plugin" === e.name) {
                    if (null !== t) throw new Error("`@plugin` cannot be nested.");
                    let o = e.params.slice(1, -1);
                    if (0 === o.length) throw new Error("`@plugin` must have a path.");
                    let a = {};
                    for (let t of e.nodes ?? []) {
                        if ("declaration" !== t.kind) throw new Error(`Unexpected \`@plugin\` option:\n\n${j([t])}\n\n\`@plugin\` options must be a flat list of declarations.`);
                        if (void 0 === t.value) continue;
                        let e = B(t.value, ",").map((e => {
                            if ("null" === (e = e.trim())) return null;
                            if ("true" === e) return !0;
                            if ("false" === e) return !1;
                            if (!Number.isNaN(Number(e))) return Number(e);
                            if ('"' === e[0] && '"' === e[e.length - 1] || "'" === e[0] && "'" === e[e.length - 1]) return e.slice(1, -1);
                            if ("{" === e[0] && "}" === e[e.length - 1]) throw new Error(`Unexpected \`@plugin\` option: Value of declaration \`${j([t]).trim()}\` is not supported.\n\nUsing an object as a plugin option is currently only supported in JavaScript configuration files.`);
                            return e
                        }));
                        a[t.property] = 1 === e.length ? e[0] : e
                    }
                    return l.push([{
                        id: o,
                        base: n.base,
                        reference: !!n.reference
                    }, Object.keys(a).length > 0 ? a : null]), r([]), void (i |= 4)
                }
                if ("@config" === e.name) {
                    if (e.nodes.length > 0) throw new Error("`@config` cannot have a body.");
                    if (null !== t) throw new Error("`@config` cannot be nested.");
                    return a.push({
                        id: e.params.slice(1, -1),
                        base: n.base,
                        reference: !!n.reference
                    }), r([]), void (i |= 4)
                }
            }
        })), function (e) {
            for (let [t, r] of [["t", "top"], ["tr", "top right"], ["r", "right"], ["br", "bottom right"], ["b", "bottom"], ["bl", "bottom left"], ["l", "left"], ["tl", "top left"]]) e.utilities.static(`bg-gradient-to-${t}`, (() => [y("--tw-gradient-position", `to ${r} in oklab`), y("background-image", "linear-gradient(var(--tw-gradient-stops))")]));
            e.utilities.functional("max-w-screen", (t => {
                if (!t.value || "arbitrary" === t.value.kind) return;
                let r = e.theme.resolve(t.value.value, ["--breakpoint"]);
                return r ? [y("max-width", r)] : void 0
            })), e.utilities.static("overflow-ellipsis", (() => [y("text-overflow", "ellipsis")])), e.utilities.static("decoration-slice", (() => [y("-webkit-box-decoration-break", "slice"), y("box-decoration-break", "slice")])), e.utilities.static("decoration-clone", (() => [y("-webkit-box-decoration-break", "clone"), y("box-decoration-break", "clone")])), e.utilities.functional("flex-shrink", (e => {
                if (!e.modifier) {
                    if (!e.value) return [y("flex-shrink", "1")];
                    if ("arbitrary" === e.value.kind) return [y("flex-shrink", e.value.value)];
                    if (ae(e.value.value)) return [y("flex-shrink", e.value.value)]
                }
            })), e.utilities.functional("flex-grow", (e => {
                if (!e.modifier) {
                    if (!e.value) return [y("flex-grow", "1")];
                    if ("arbitrary" === e.value.kind) return [y("flex-grow", e.value.value)];
                    if (ae(e.value.value)) return [y("flex-grow", e.value.value)]
                }
            }))
        }(e);
        let s = e.resolveThemeValue;
        if (e.resolveThemeValue = function (n) {
            return n.startsWith("--") ? s(n) : (i |= Wt({
                designSystem: e,
                base: t,
                ast: r,
                globs: o,
                configs: [],
                pluginDetails: []
            }), e.resolveThemeValue(n))
        }, !l.length && !a.length) return 0;
        let [c, u] = await Promise.all([Promise.all(a.map((async ({id: e, base: t, reference: r}) => {
            let o = await n(e, t, "config");
            return {path: e, base: o.base, config: o.module, reference: r}
        }))), Promise.all(l.map((async ([{id: e, base: t, reference: r}, o]) => {
            let i = await n(e, t, "plugin");
            return {path: e, base: i.base, plugin: i.module, options: o, reference: r}
        })))]);
        return i |= Wt({designSystem: e, base: t, ast: r, globs: o, configs: c, pluginDetails: u}), i
    }

    function Wt({designSystem: e, base: t, ast: r, globs: n, configs: o, pluginDetails: i}) {
        let l = 0, a = [...i.map((e => {
            if (!e.options) return {config: {plugins: [e.plugin]}, base: e.base, reference: e.reference};
            if ("__isOptionsFunction" in e.plugin) return {
                config: {plugins: [e.plugin(e.options)]},
                base: e.base,
                reference: e.reference
            };
            throw new Error(`The plugin "${e.path}" does not accept options`)
        })), ...o], {resolvedConfig: s} = Kt(e, [{
            config: Tt(e.theme),
            base: t,
            reference: !0
        }, ...a, {config: {plugins: [Nt]}, base: t, reference: !0}]), {
            resolvedConfig: c,
            replacedThemeKeys: u
        } = Kt(e, a);
        e.resolveThemeValue = function (e, t) {
            let r = h.theme(e, t);
            return Array.isArray(r) && 2 === r.length ? r[0] : Array.isArray(r) ? r.join(", ") : "string" == typeof r ? r : void 0
        };
        let d, f = {
            designSystem: e, ast: r, resolvedConfig: s, featuresRef: {
                set current(e) {
                    l |= e
                }
            }
        }, h = ft({...f, referenceMode: !1});
        for (let {handler: e, reference: t} of s.plugins) t ? (d ||= ft({...f, referenceMode: !0}), e(d)) : e(h);
        if (He(e, c, u), gt(e, c), function (e, t) {
            let r = e.theme.aria || {}, n = e.theme.supports || {}, o = e.theme.data || {};
            if (Object.keys(r).length > 0) {
                let e = t.variants.get("aria"), n = e?.applyFn, o = e?.compounds;
                t.variants.functional("aria", ((e, t) => {
                    let o = t.value;
                    return o && "named" === o.kind && o.value in r ? n?.(e, {
                        ...t,
                        value: {kind: "arbitrary", value: r[o.value]}
                    }) : n?.(e, t)
                }), {compounds: o})
            }
            if (Object.keys(n).length > 0) {
                let e = t.variants.get("supports"), r = e?.applyFn, o = e?.compounds;
                t.variants.functional("supports", ((e, t) => {
                    let o = t.value;
                    return o && "named" === o.kind && o.value in n ? r?.(e, {
                        ...t,
                        value: {kind: "arbitrary", value: n[o.value]}
                    }) : r?.(e, t)
                }), {compounds: o})
            }
            if (Object.keys(o).length > 0) {
                let e = t.variants.get("data"), r = e?.applyFn, n = e?.compounds;
                t.variants.functional("data", ((e, t) => {
                    let n = t.value;
                    return n && "named" === n.kind && n.value in o ? r?.(e, {
                        ...t,
                        value: {kind: "arbitrary", value: o[n.value]}
                    }) : r?.(e, t)
                }), {compounds: n})
            }
        }(c, e), function (e, t) {
            let r = e.theme.screens || {}, n = t.variants.get("min")?.order ?? 0, o = [];
            for (let [e, i] of Object.entries(r)) {
                let r = function (r) {
                    t.variants.static(e, (e => {
                        e.nodes = [w("@media", c, e.nodes)]
                    }), {order: r})
                }, l = t.variants.get(e), a = t.theme.resolveValue(e, ["--breakpoint"]);
                if (l && a && !t.theme.hasDefault(`--breakpoint-${e}`)) continue;
                let s = !0;
                "string" == typeof i && (s = !1);
                let c = Ot(i);
                s ? o.push(r) : r(n)
            }
            if (0 !== o.length) {
                for (let [, e] of t.variants.variants) e.order > n && (e.order += o.length);
                t.variants.compareFns = new Map(Array.from(t.variants.compareFns).map((([e, t]) => (e > n && (e += o.length), [e, t]))));
                for (let [e, t] of o.entries()) t(n + e + 1)
            }
        }(c, e), Vt(c, e), !e.theme.prefix && s.prefix) {
            if (s.prefix.endsWith("-") && (s.prefix = s.prefix.slice(0, -1), console.warn(`The prefix "${s.prefix}" is invalid. Prefixes must be lowercase ASCII letters (a-z) only and is written as a variant before all utilities. We have fixed up the prefix for you. Remove the trailing \`-\` to silence this warning.`)), !Ft.test(s.prefix)) throw new Error(`The prefix "${s.prefix}" is invalid. Prefixes must be lowercase ASCII letters (a-z) only.`);
            e.theme.prefix = s.prefix
        }
        if (!e.important && !0 === s.important && (e.important = !0), "string" == typeof s.important) {
            let e = s.important;
            z(r, ((t, {replaceWith: r, parent: n}) => {
                if ("at-rule" === t.kind && "@tailwind" === t.name && "utilities" === t.params) return "rule" === n?.kind && n.selector === e || r(b(e, [t])), 2
            }))
        }
        for (let t of s.blocklist) e.invalidCandidates.add(t);
        for (let e of s.content.files) {
            if ("raw" in e) throw new Error(`Error in the config file/plugin/preset. The \`content\` key contains a \`raw\` entry:\n\n${JSON.stringify(e, null, 2)}\n\nThis feature is not currently supported.`);
            n.push(e)
        }
        return l
    }

    var Dt = /^[a-z]+$/;

    function _t() {
        throw new Error("No `loadModule` function provided to `compile`")
    }

    function Bt() {
        throw new Error("No `loadStylesheet` function provided to `compile`")
    }

    async function Lt(e, {base: t = "", loadModule: r = _t, loadStylesheet: n = Bt} = {}) {
        let l = 0;
        e = [$({base: t}, e)], l |= await qe(e, t, n);
        let a = null, c = new s, u = [], d = [], f = null, g = null, v = [], x = [], C = [], T = [], K = null;
        z(e, ((e, {parent: t, replaceWith: r, context: n}) => {
            if ("at-rule" === e.kind) {
                if ("@tailwind" === e.name && ("utilities" === e.params || e.params.startsWith("utilities"))) {
                    if (null !== g) return void r([]);
                    let t = B(e.params, " ");
                    for (let e of t) if (e.startsWith("source(")) {
                        let t = e.slice(7, -1);
                        if ("none" === t) {
                            K = t;
                            continue
                        }
                        if ('"' === t[0] && '"' !== t[t.length - 1] || "'" === t[0] && "'" !== t[t.length - 1] || "'" !== t[0] && '"' !== t[0]) throw new Error("`source(…)` paths must be quoted.");
                        K = {base: n.sourceBase ?? n.base, pattern: t.slice(1, -1)}
                    }
                    g = e, l |= 16
                }
                if ("@utility" === e.name) {
                    if (null !== t) throw new Error("`@utility` cannot be nested.");
                    if (0 === e.nodes.length) throw new Error(`\`@utility ${e.params}\` is empty. Utilities should include at least one property.`);
                    let r = function (e) {
                        let t = e.params;
                        return ge.test(t) ? r => {
                            let n = new Set, o = new Set;
                            z(e.nodes, (e => {
                                if ("declaration" !== e.kind || !e.value || !e.value.includes("--value(") && !e.value.includes("--modifier(")) return;
                                let t = m(e.value);
                                h(t, (e => {
                                    if ("function" !== e.kind || "--value" !== e.value && "--modifier" !== e.value) return;
                                    let t = B(p(e.nodes), ",");
                                    for (let [e, r] of t.entries()) r = r.replace(/\\\*/g, "*"), r = r.replace(/--(.*?)\s--(.*?)/g, "--$1-*--$2"), r = r.replace(/\s+/g, ""), r = r.replace(/(-\*){2,}/g, "-*"), "-" === r[0] && "-" === r[1] && !r.includes("-*") && (r += "-*"), t[e] = r;
                                    e.nodes = m(t.join(","));
                                    for (let t of e.nodes) if ("word" === t.kind && "-" === t.value[0] && "-" === t.value[1]) {
                                        let r = t.value.replace(/-\*.*$/g, "");
                                        "--value" === e.value ? n.add(r) : "--modifier" === e.value && o.add(r)
                                    }
                                })), e.value = p(t)
                            })), r.utilities.functional(t.slice(0, -2), (t => {
                                let n = structuredClone(e), o = t.value, i = t.modifier;
                                if (null === o) return;
                                let l = !1, a = !1, s = !1, c = !1, u = new Map, d = !1;
                                if (z([n], ((e, {parent: t, replaceWith: n}) => {
                                    if ("rule" !== t?.kind && "at-rule" !== t?.kind || "declaration" !== e.kind || !e.value) return;
                                    let f = m(e.value);
                                    0 === (h(f, ((f, {replaceWith: h}) => {
                                        if ("function" === f.kind) {
                                            if ("--value" === f.value) {
                                                l = !0;
                                                let i = xe(o, f, r);
                                                return i ? (a = !0, i.ratio ? d = !0 : u.set(e, t), h(i.nodes), 1) : (l ||= !1, n([]), 2)
                                            }
                                            if ("--modifier" === f.value) {
                                                if (null === i) return n([]), 1;
                                                s = !0;
                                                let e = xe(i, f, r);
                                                return e ? (c = !0, h(e.nodes), 1) : (s ||= !1, n([]), 2)
                                            }
                                        }
                                    })) ?? 0) && (e.value = p(f))
                                })), l && !a || s && !c || d && c || i && !d && !c) return null;
                                if (d) for (let [e, t] of u) {
                                    let r = t.nodes.indexOf(e);
                                    -1 !== r && t.nodes.splice(r, 1)
                                }
                                return n.nodes
                            })), r.utilities.suggest(t.slice(0, -2), (() => [{
                                values: r.theme.keysInNamespaces(n).map((e => e.replaceAll("_", "."))),
                                modifiers: r.theme.keysInNamespaces(o).map((e => e.replaceAll("_", ".")))
                            }]))
                        } : me.test(t) ? r => {
                            r.utilities.static(t, (() => structuredClone(e.nodes)))
                        } : null
                    }(e);
                    if (null === r) throw new Error(`\`@utility ${e.params}\` defines an invalid utility name. Utilities should be alphanumeric and start with a lowercase letter.`);
                    d.push(r)
                }
                if ("@source" === e.name) {
                    if (e.nodes.length > 0) throw new Error("`@source` cannot have a body.");
                    if (null !== t) throw new Error("`@source` cannot be nested.");
                    let o = e.params;
                    if ('"' === o[0] && '"' !== o[o.length - 1] || "'" === o[0] && "'" !== o[o.length - 1] || "'" !== o[0] && '"' !== o[0]) throw new Error("`@source` paths must be quoted.");
                    let i = o.slice(1, -1);
                    return x.push({base: n.base, pattern: i}), void r([])
                }
                if ("@variant" === e.name && (null === t ? 0 === e.nodes.length ? e.name = "@custom-variant" : (z(e.nodes, (t => {
                    if ("at-rule" === t.kind && "@slot" === t.name) return e.name = "@custom-variant", 2
                })), "@variant" === e.name && v.push(e)) : v.push(e)), "@custom-variant" === e.name) {
                    if (null !== t) throw new Error("`@custom-variant` cannot be nested.");
                    r([]);
                    let [n, o] = B(e.params, " ");
                    if (!Ee.test(n)) throw new Error(`\`@custom-variant ${n}\` defines an invalid variant name. Variants should only contain alphanumeric, dashes or underscore characters.`);
                    if (e.nodes.length > 0 && o) throw new Error(`\`@custom-variant ${n}\` cannot have both a selector and a body.`);
                    if (0 === e.nodes.length) {
                        if (!o) throw new Error(`\`@custom-variant ${n}\` has no selector or body.`);
                        let e = B(o.slice(1, -1), ",");
                        if (0 === e.length || e.some((e => "" === e.trim()))) throw new Error(`\`@custom-variant ${n} (${e.join(",")})\` selector is invalid.`);
                        let t = [], r = [];
                        for (let n of e) n = n.trim(), "@" === n[0] ? t.push(n) : r.push(n);
                        return void u.push((e => {
                            e.variants.static(n, (e => {
                                let n = [];
                                r.length > 0 && n.push(b(r.join(", "), e.nodes));
                                for (let r of t) n.push(k(r, e.nodes));
                                e.nodes = n
                            }), {compounds: Ne([...r, ...t])})
                        }))
                    }
                    return void u.push((t => {
                        t.variants.fromAst(n, e.nodes)
                    }))
                }
                if ("@media" === e.name) {
                    let t = B(e.params, " "), o = [];
                    for (let r of t) if (r.startsWith("source(")) {
                        let t = r.slice(7, -1);
                        z(e.nodes, ((e, {replaceWith: r}) => {
                            if ("at-rule" === e.kind && "@tailwind" === e.name && "utilities" === e.params) return e.params += ` source(${t})`, r([$({sourceBase: n.base}, [e])]), 2
                        }))
                    } else if (r.startsWith("theme(")) {
                        let t = r.slice(6, -1), n = t.includes("reference");
                        z(e.nodes, (e => {
                            if ("at-rule" !== e.kind) {
                                if (n) throw new Error('Files imported with `@import "…" theme(reference)` must only contain `@theme` blocks.\nUse `@reference "…";` instead.');
                                return 0
                            }
                            if ("@theme" === e.name) return e.params += " " + t, 1
                        }))
                    } else if (r.startsWith("prefix(")) {
                        let t = r.slice(7, -1);
                        z(e.nodes, (e => {
                            if ("at-rule" === e.kind && "@theme" === e.name) return e.params += ` prefix(${t})`, 1
                        }))
                    } else "important" === r ? a = !0 : "reference" === r ? e.nodes = [$({reference: !0}, e.nodes)] : o.push(r);
                    o.length > 0 ? e.params = o.join(" ") : t.length > 0 && r(e.nodes)
                }
                if ("@theme" === e.name) {
                    let [t, o] = function (e) {
                        let t = 0, r = null;
                        for (let n of B(e, " ")) "reference" === n ? t |= 2 : "inline" === n ? t |= 1 : "default" === n ? t |= 4 : "static" === n ? t |= 8 : n.startsWith("prefix(") && n.endsWith(")") && (r = n.slice(7, -1));
                        return [t, r]
                    }(e.params);
                    if (n.reference && (t |= 2), o) {
                        if (!Dt.test(o)) throw new Error(`The prefix "${o}" is invalid. Prefixes must be lowercase ASCII letters (a-z) only.`);
                        c.prefix = o
                    }
                    return z(e.nodes, (r => {
                        if ("at-rule" === r.kind && "@keyframes" === r.name) return c.addKeyframes(r), 1;
                        if ("comment" === r.kind) return;
                        if ("declaration" === r.kind && r.property.startsWith("--")) return void c.add(i(r.property), r.value ?? "", t);
                        let n = j([w(e.name, e.params, [r])]).split("\n").map(((e, t, r) => `${0 === t || t >= r.length - 2 ? " " : ">"} ${e}`)).join("\n");
                        throw new Error(`\`@theme\` blocks must only contain custom properties or \`@keyframes\`.\n\n${n}`)
                    })), f ? r([]) : (f = b(":root, :host", []), r([f])), 1
                }
            }
        }));
        let S = Ue(c);
        if (a && (S.important = a), T.length > 0) for (let e of T) S.invalidCandidates.add(e);
        l |= await Ut({designSystem: S, base: t, ast: e, loadModule: r, globs: x});
        for (let e of u) e(S);
        for (let e of d) e(S);
        if (f) {
            let t = [];
            for (let [e, r] of S.theme.entries()) 2 & r.options || t.push(y(o(e), r.value));
            let r = S.theme.getKeyframes();
            for (let t of r) e.push($({theme: !0}, [A([t])]));
            f.nodes = [$({theme: !0}, t)]
        }
        if (g) {
            let e = g;
            e.kind = "context", e.context = {}
        }
        if (v.length > 0) {
            for (let e of v) {
                let t = b("&", e.nodes), r = e.params, n = S.parseVariant(r);
                if (null === n) throw new Error(`Cannot use \`@variant\` with unknown variant: ${r}`);
                if (null === _e(t, n, S.variants)) throw new Error(`Cannot use \`@variant\` with variant: ${r}`);
                Object.assign(e, t)
            }
            l |= 32
        }
        return l |= Ce(e, S), l |= Re(e, S), z(e, ((e, {replaceWith: t}) => {
            if ("at-rule" === e.kind) return "@utility" === e.name && t([]), 1
        })), {designSystem: S, ast: e, globs: x, root: K, utilitiesNode: g, features: l, inlineCandidates: C}
    }

    async function Mt(e, r = {}) {
        let n = t(e), o = await async function (e, t = {}) {
            let {
                designSystem: r,
                ast: n,
                globs: o,
                root: i,
                utilitiesNode: l,
                features: a,
                inlineCandidates: s
            } = await Lt(e, t);

            function c(e) {
                r.invalidCandidates.add(e)
            }

            n.unshift(x("! tailwindcss v4.0.14 | MIT License | https://tailwindcss.com "));
            let u = new Set, d = null, f = 0, h = !1;
            for (let e of s) r.invalidCandidates.has(e) || (u.add(e), h = !0);
            return {
                globs: o, root: i, features: a, build(t) {
                    if (0 === a) return e;
                    if (!l) return d ??= T(n, r), d;
                    let o = h;
                    h = !1;
                    let i = u.size;
                    for (let e of t) r.invalidCandidates.has(e) || ("-" === e[0] && "-" === e[1] ? r.theme.markUsedVariable(e) : u.add(e), o ||= u.size !== i);
                    if (!o) return d ??= T(n, r), d;
                    let s = De(u, r, {onInvalidCandidate: c}).astNodes;
                    return f === s.length ? (d ??= T(n, r), d) : (f = s.length, l.nodes = s, d = T(n, r), d)
                }
            }
        }(n, r), i = n, l = e;
        return {
            ...o, build(e) {
                let t = o.build(e);
                return t === i || (l = j(t), i = t), l
            }
        }
    }

    var Rt = {
        index: "@layer theme, base, components, utilities;\n\n@import './theme.css' layer(theme);\n@import './preflight.css' layer(base);\n@import './utilities.css' layer(utilities);\n",
        preflight: "/*\n  1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)\n  2. Remove default margins and padding\n  3. Reset all borders.\n*/\n\n*,\n::after,\n::before,\n::backdrop,\n::file-selector-button {\n  box-sizing: border-box; /* 1 */\n  margin: 0; /* 2 */\n  padding: 0; /* 2 */\n  border: 0 solid; /* 3 */\n}\n\n/*\n  1. Use a consistent sensible line-height in all browsers.\n  2. Prevent adjustments of font size after orientation changes in iOS.\n  3. Use a more readable tab size.\n  4. Use the user's configured `sans` font-family by default.\n  5. Use the user's configured `sans` font-feature-settings by default.\n  6. Use the user's configured `sans` font-variation-settings by default.\n  7. Disable tap highlights on iOS.\n*/\n\nhtml,\n:host {\n  line-height: 1.5; /* 1 */\n  -webkit-text-size-adjust: 100%; /* 2 */\n  tab-size: 4; /* 3 */\n  font-family: var(\n    --default-font-family,\n    ui-sans-serif,\n    system-ui,\n    sans-serif,\n    'Apple Color Emoji',\n    'Segoe UI Emoji',\n    'Segoe UI Symbol',\n    'Noto Color Emoji'\n  ); /* 4 */\n  font-feature-settings: var(--default-font-feature-settings, normal); /* 5 */\n  font-variation-settings: var(--default-font-variation-settings, normal); /* 6 */\n  -webkit-tap-highlight-color: transparent; /* 7 */\n}\n\n/*\n  Inherit line-height from `html` so users can set them as a class directly on the `html` element.\n*/\n\nbody {\n  line-height: inherit;\n}\n\n/*\n  1. Add the correct height in Firefox.\n  2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)\n  3. Reset the default border style to a 1px solid border.\n*/\n\nhr {\n  height: 0; /* 1 */\n  color: inherit; /* 2 */\n  border-top-width: 1px; /* 3 */\n}\n\n/*\n  Add the correct text decoration in Chrome, Edge, and Safari.\n*/\n\nabbr:where([title]) {\n  -webkit-text-decoration: underline dotted;\n  text-decoration: underline dotted;\n}\n\n/*\n  Remove the default font size and weight for headings.\n*/\n\nh1,\nh2,\nh3,\nh4,\nh5,\nh6 {\n  font-size: inherit;\n  font-weight: inherit;\n}\n\n/*\n  Reset links to optimize for opt-in styling instead of opt-out.\n*/\n\na {\n  color: inherit;\n  -webkit-text-decoration: inherit;\n  text-decoration: inherit;\n}\n\n/*\n  Add the correct font weight in Edge and Safari.\n*/\n\nb,\nstrong {\n  font-weight: bolder;\n}\n\n/*\n  1. Use the user's configured `mono` font-family by default.\n  2. Use the user's configured `mono` font-feature-settings by default.\n  3. Use the user's configured `mono` font-variation-settings by default.\n  4. Correct the odd `em` font sizing in all browsers.\n*/\n\ncode,\nkbd,\nsamp,\npre {\n  font-family: var(\n    --default-mono-font-family,\n    ui-monospace,\n    SFMono-Regular,\n    Menlo,\n    Monaco,\n    Consolas,\n    'Liberation Mono',\n    'Courier New',\n    monospace\n  ); /* 1 */\n  font-feature-settings: var(--default-mono-font-feature-settings, normal); /* 2 */\n  font-variation-settings: var(--default-mono-font-variation-settings, normal); /* 3 */\n  font-size: 1em; /* 4 */\n}\n\n/*\n  Add the correct font size in all browsers.\n*/\n\nsmall {\n  font-size: 80%;\n}\n\n/*\n  Prevent `sub` and `sup` elements from affecting the line height in all browsers.\n*/\n\nsub,\nsup {\n  font-size: 75%;\n  line-height: 0;\n  position: relative;\n  vertical-align: baseline;\n}\n\nsub {\n  bottom: -0.25em;\n}\n\nsup {\n  top: -0.5em;\n}\n\n/*\n  1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)\n  2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)\n  3. Remove gaps between table borders by default.\n*/\n\ntable {\n  text-indent: 0; /* 1 */\n  border-color: inherit; /* 2 */\n  border-collapse: collapse; /* 3 */\n}\n\n/*\n  Use the modern Firefox focus style for all focusable elements.\n*/\n\n:-moz-focusring {\n  outline: auto;\n}\n\n/*\n  Add the correct vertical alignment in Chrome and Firefox.\n*/\n\nprogress {\n  vertical-align: baseline;\n}\n\n/*\n  Add the correct display in Chrome and Safari.\n*/\n\nsummary {\n  display: list-item;\n}\n\n/*\n  Make lists unstyled by default.\n*/\n\nol,\nul,\nmenu {\n  list-style: none;\n}\n\n/*\n  1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)\n  2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)\n      This can trigger a poorly considered lint error in some tools but is included by design.\n*/\n\nimg,\nsvg,\nvideo,\ncanvas,\naudio,\niframe,\nembed,\nobject {\n  display: block; /* 1 */\n  vertical-align: middle; /* 2 */\n}\n\n/*\n  Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)\n*/\n\nimg,\nvideo {\n  max-width: 100%;\n  height: auto;\n}\n\n/*\n  1. Inherit font styles in all browsers.\n  2. Remove border radius in all browsers.\n  3. Remove background color in all browsers.\n  4. Ensure consistent opacity for disabled states in all browsers.\n*/\n\nbutton,\ninput,\nselect,\noptgroup,\ntextarea,\n::file-selector-button {\n  font: inherit; /* 1 */\n  font-feature-settings: inherit; /* 1 */\n  font-variation-settings: inherit; /* 1 */\n  letter-spacing: inherit; /* 1 */\n  color: inherit; /* 1 */\n  border-radius: 0; /* 2 */\n  background-color: transparent; /* 3 */\n  opacity: 1; /* 4 */\n}\n\n/*\n  Restore default font weight.\n*/\n\n:where(select:is([multiple], [size])) optgroup {\n  font-weight: bolder;\n}\n\n/*\n  Restore indentation.\n*/\n\n:where(select:is([multiple], [size])) optgroup option {\n  padding-inline-start: 20px;\n}\n\n/*\n  Restore space after button.\n*/\n\n::file-selector-button {\n  margin-inline-end: 4px;\n}\n\n/*\n  1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)\n  2. Set the default placeholder color to a semi-transparent version of the current text color.\n*/\n\n::placeholder {\n  opacity: 1; /* 1 */\n  color: color-mix(in oklab, currentColor 50%, transparent); /* 2 */\n}\n\n/*\n  Prevent resizing textareas horizontally by default.\n*/\n\ntextarea {\n  resize: vertical;\n}\n\n/*\n  Remove the inner padding in Chrome and Safari on macOS.\n*/\n\n::-webkit-search-decoration {\n  -webkit-appearance: none;\n}\n\n/*\n  1. Ensure date/time inputs have the same height when empty in iOS Safari.\n  2. Ensure text alignment can be changed on date/time inputs in iOS Safari.\n*/\n\n::-webkit-date-and-time-value {\n  min-height: 1lh; /* 1 */\n  text-align: inherit; /* 2 */\n}\n\n/*\n  Prevent height from changing on date/time inputs in macOS Safari when the input is set to `display: block`.\n*/\n\n::-webkit-datetime-edit {\n  display: inline-flex;\n}\n\n/*\n  Remove excess padding from pseudo-elements in date/time inputs to ensure consistent height across browsers.\n*/\n\n::-webkit-datetime-edit-fields-wrapper {\n  padding: 0;\n}\n\n::-webkit-datetime-edit,\n::-webkit-datetime-edit-year-field,\n::-webkit-datetime-edit-month-field,\n::-webkit-datetime-edit-day-field,\n::-webkit-datetime-edit-hour-field,\n::-webkit-datetime-edit-minute-field,\n::-webkit-datetime-edit-second-field,\n::-webkit-datetime-edit-millisecond-field,\n::-webkit-datetime-edit-meridiem-field {\n  padding-block: 0;\n}\n\n/*\n  Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)\n*/\n\n:-moz-ui-invalid {\n  box-shadow: none;\n}\n\n/*\n  Correct the inability to style the border radius in iOS Safari.\n*/\n\nbutton,\ninput:where([type='button'], [type='reset'], [type='submit']),\n::file-selector-button {\n  appearance: button;\n}\n\n/*\n  Correct the cursor style of increment and decrement buttons in Safari.\n*/\n\n::-webkit-inner-spin-button,\n::-webkit-outer-spin-button {\n  height: auto;\n}\n\n/*\n  Make elements with the HTML hidden attribute stay hidden by default.\n*/\n\n[hidden]:where(:not([hidden='until-found'])) {\n  display: none !important;\n}\n",
        theme: "@theme default {\n  --font-sans:\n    ui-sans-serif, system-ui, sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol',\n    'Noto Color Emoji';\n  --font-serif: ui-serif, Georgia, Cambria, 'Times New Roman', Times, serif;\n  --font-mono:\n    ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, 'Liberation Mono', 'Courier New',\n    monospace;\n\n  --color-red-50: oklch(0.971 0.013 17.38);\n  --color-red-100: oklch(0.936 0.032 17.717);\n  --color-red-200: oklch(0.885 0.062 18.334);\n  --color-red-300: oklch(0.808 0.114 19.571);\n  --color-red-400: oklch(0.704 0.191 22.216);\n  --color-red-500: oklch(0.637 0.237 25.331);\n  --color-red-600: oklch(0.577 0.245 27.325);\n  --color-red-700: oklch(0.505 0.213 27.518);\n  --color-red-800: oklch(0.444 0.177 26.899);\n  --color-red-900: oklch(0.396 0.141 25.723);\n  --color-red-950: oklch(0.258 0.092 26.042);\n\n  --color-orange-50: oklch(0.98 0.016 73.684);\n  --color-orange-100: oklch(0.954 0.038 75.164);\n  --color-orange-200: oklch(0.901 0.076 70.697);\n  --color-orange-300: oklch(0.837 0.128 66.29);\n  --color-orange-400: oklch(0.75 0.183 55.934);\n  --color-orange-500: oklch(0.705 0.213 47.604);\n  --color-orange-600: oklch(0.646 0.222 41.116);\n  --color-orange-700: oklch(0.553 0.195 38.402);\n  --color-orange-800: oklch(0.47 0.157 37.304);\n  --color-orange-900: oklch(0.408 0.123 38.172);\n  --color-orange-950: oklch(0.266 0.079 36.259);\n\n  --color-amber-50: oklch(0.987 0.022 95.277);\n  --color-amber-100: oklch(0.962 0.059 95.617);\n  --color-amber-200: oklch(0.924 0.12 95.746);\n  --color-amber-300: oklch(0.879 0.169 91.605);\n  --color-amber-400: oklch(0.828 0.189 84.429);\n  --color-amber-500: oklch(0.769 0.188 70.08);\n  --color-amber-600: oklch(0.666 0.179 58.318);\n  --color-amber-700: oklch(0.555 0.163 48.998);\n  --color-amber-800: oklch(0.473 0.137 46.201);\n  --color-amber-900: oklch(0.414 0.112 45.904);\n  --color-amber-950: oklch(0.279 0.077 45.635);\n\n  --color-yellow-50: oklch(0.987 0.026 102.212);\n  --color-yellow-100: oklch(0.973 0.071 103.193);\n  --color-yellow-200: oklch(0.945 0.129 101.54);\n  --color-yellow-300: oklch(0.905 0.182 98.111);\n  --color-yellow-400: oklch(0.852 0.199 91.936);\n  --color-yellow-500: oklch(0.795 0.184 86.047);\n  --color-yellow-600: oklch(0.681 0.162 75.834);\n  --color-yellow-700: oklch(0.554 0.135 66.442);\n  --color-yellow-800: oklch(0.476 0.114 61.907);\n  --color-yellow-900: oklch(0.421 0.095 57.708);\n  --color-yellow-950: oklch(0.286 0.066 53.813);\n\n  --color-lime-50: oklch(0.986 0.031 120.757);\n  --color-lime-100: oklch(0.967 0.067 122.328);\n  --color-lime-200: oklch(0.938 0.127 124.321);\n  --color-lime-300: oklch(0.897 0.196 126.665);\n  --color-lime-400: oklch(0.841 0.238 128.85);\n  --color-lime-500: oklch(0.768 0.233 130.85);\n  --color-lime-600: oklch(0.648 0.2 131.684);\n  --color-lime-700: oklch(0.532 0.157 131.589);\n  --color-lime-800: oklch(0.453 0.124 130.933);\n  --color-lime-900: oklch(0.405 0.101 131.063);\n  --color-lime-950: oklch(0.274 0.072 132.109);\n\n  --color-green-50: oklch(0.982 0.018 155.826);\n  --color-green-100: oklch(0.962 0.044 156.743);\n  --color-green-200: oklch(0.925 0.084 155.995);\n  --color-green-300: oklch(0.871 0.15 154.449);\n  --color-green-400: oklch(0.792 0.209 151.711);\n  --color-green-500: oklch(0.723 0.219 149.579);\n  --color-green-600: oklch(0.627 0.194 149.214);\n  --color-green-700: oklch(0.527 0.154 150.069);\n  --color-green-800: oklch(0.448 0.119 151.328);\n  --color-green-900: oklch(0.393 0.095 152.535);\n  --color-green-950: oklch(0.266 0.065 152.934);\n\n  --color-emerald-50: oklch(0.979 0.021 166.113);\n  --color-emerald-100: oklch(0.95 0.052 163.051);\n  --color-emerald-200: oklch(0.905 0.093 164.15);\n  --color-emerald-300: oklch(0.845 0.143 164.978);\n  --color-emerald-400: oklch(0.765 0.177 163.223);\n  --color-emerald-500: oklch(0.696 0.17 162.48);\n  --color-emerald-600: oklch(0.596 0.145 163.225);\n  --color-emerald-700: oklch(0.508 0.118 165.612);\n  --color-emerald-800: oklch(0.432 0.095 166.913);\n  --color-emerald-900: oklch(0.378 0.077 168.94);\n  --color-emerald-950: oklch(0.262 0.051 172.552);\n\n  --color-teal-50: oklch(0.984 0.014 180.72);\n  --color-teal-100: oklch(0.953 0.051 180.801);\n  --color-teal-200: oklch(0.91 0.096 180.426);\n  --color-teal-300: oklch(0.855 0.138 181.071);\n  --color-teal-400: oklch(0.777 0.152 181.912);\n  --color-teal-500: oklch(0.704 0.14 182.503);\n  --color-teal-600: oklch(0.6 0.118 184.704);\n  --color-teal-700: oklch(0.511 0.096 186.391);\n  --color-teal-800: oklch(0.437 0.078 188.216);\n  --color-teal-900: oklch(0.386 0.063 188.416);\n  --color-teal-950: oklch(0.277 0.046 192.524);\n\n  --color-cyan-50: oklch(0.984 0.019 200.873);\n  --color-cyan-100: oklch(0.956 0.045 203.388);\n  --color-cyan-200: oklch(0.917 0.08 205.041);\n  --color-cyan-300: oklch(0.865 0.127 207.078);\n  --color-cyan-400: oklch(0.789 0.154 211.53);\n  --color-cyan-500: oklch(0.715 0.143 215.221);\n  --color-cyan-600: oklch(0.609 0.126 221.723);\n  --color-cyan-700: oklch(0.52 0.105 223.128);\n  --color-cyan-800: oklch(0.45 0.085 224.283);\n  --color-cyan-900: oklch(0.398 0.07 227.392);\n  --color-cyan-950: oklch(0.302 0.056 229.695);\n\n  --color-sky-50: oklch(0.977 0.013 236.62);\n  --color-sky-100: oklch(0.951 0.026 236.824);\n  --color-sky-200: oklch(0.901 0.058 230.902);\n  --color-sky-300: oklch(0.828 0.111 230.318);\n  --color-sky-400: oklch(0.746 0.16 232.661);\n  --color-sky-500: oklch(0.685 0.169 237.323);\n  --color-sky-600: oklch(0.588 0.158 241.966);\n  --color-sky-700: oklch(0.5 0.134 242.749);\n  --color-sky-800: oklch(0.443 0.11 240.79);\n  --color-sky-900: oklch(0.391 0.09 240.876);\n  --color-sky-950: oklch(0.293 0.066 243.157);\n\n  --color-blue-50: oklch(0.97 0.014 254.604);\n  --color-blue-100: oklch(0.932 0.032 255.585);\n  --color-blue-200: oklch(0.882 0.059 254.128);\n  --color-blue-300: oklch(0.809 0.105 251.813);\n  --color-blue-400: oklch(0.707 0.165 254.624);\n  --color-blue-500: oklch(0.623 0.214 259.815);\n  --color-blue-600: oklch(0.546 0.245 262.881);\n  --color-blue-700: oklch(0.488 0.243 264.376);\n  --color-blue-800: oklch(0.424 0.199 265.638);\n  --color-blue-900: oklch(0.379 0.146 265.522);\n  --color-blue-950: oklch(0.282 0.091 267.935);\n\n  --color-indigo-50: oklch(0.962 0.018 272.314);\n  --color-indigo-100: oklch(0.93 0.034 272.788);\n  --color-indigo-200: oklch(0.87 0.065 274.039);\n  --color-indigo-300: oklch(0.785 0.115 274.713);\n  --color-indigo-400: oklch(0.673 0.182 276.935);\n  --color-indigo-500: oklch(0.585 0.233 277.117);\n  --color-indigo-600: oklch(0.511 0.262 276.966);\n  --color-indigo-700: oklch(0.457 0.24 277.023);\n  --color-indigo-800: oklch(0.398 0.195 277.366);\n  --color-indigo-900: oklch(0.359 0.144 278.697);\n  --color-indigo-950: oklch(0.257 0.09 281.288);\n\n  --color-violet-50: oklch(0.969 0.016 293.756);\n  --color-violet-100: oklch(0.943 0.029 294.588);\n  --color-violet-200: oklch(0.894 0.057 293.283);\n  --color-violet-300: oklch(0.811 0.111 293.571);\n  --color-violet-400: oklch(0.702 0.183 293.541);\n  --color-violet-500: oklch(0.606 0.25 292.717);\n  --color-violet-600: oklch(0.541 0.281 293.009);\n  --color-violet-700: oklch(0.491 0.27 292.581);\n  --color-violet-800: oklch(0.432 0.232 292.759);\n  --color-violet-900: oklch(0.38 0.189 293.745);\n  --color-violet-950: oklch(0.283 0.141 291.089);\n\n  --color-purple-50: oklch(0.977 0.014 308.299);\n  --color-purple-100: oklch(0.946 0.033 307.174);\n  --color-purple-200: oklch(0.902 0.063 306.703);\n  --color-purple-300: oklch(0.827 0.119 306.383);\n  --color-purple-400: oklch(0.714 0.203 305.504);\n  --color-purple-500: oklch(0.627 0.265 303.9);\n  --color-purple-600: oklch(0.558 0.288 302.321);\n  --color-purple-700: oklch(0.496 0.265 301.924);\n  --color-purple-800: oklch(0.438 0.218 303.724);\n  --color-purple-900: oklch(0.381 0.176 304.987);\n  --color-purple-950: oklch(0.291 0.149 302.717);\n\n  --color-fuchsia-50: oklch(0.977 0.017 320.058);\n  --color-fuchsia-100: oklch(0.952 0.037 318.852);\n  --color-fuchsia-200: oklch(0.903 0.076 319.62);\n  --color-fuchsia-300: oklch(0.833 0.145 321.434);\n  --color-fuchsia-400: oklch(0.74 0.238 322.16);\n  --color-fuchsia-500: oklch(0.667 0.295 322.15);\n  --color-fuchsia-600: oklch(0.591 0.293 322.896);\n  --color-fuchsia-700: oklch(0.518 0.253 323.949);\n  --color-fuchsia-800: oklch(0.452 0.211 324.591);\n  --color-fuchsia-900: oklch(0.401 0.17 325.612);\n  --color-fuchsia-950: oklch(0.293 0.136 325.661);\n\n  --color-pink-50: oklch(0.971 0.014 343.198);\n  --color-pink-100: oklch(0.948 0.028 342.258);\n  --color-pink-200: oklch(0.899 0.061 343.231);\n  --color-pink-300: oklch(0.823 0.12 346.018);\n  --color-pink-400: oklch(0.718 0.202 349.761);\n  --color-pink-500: oklch(0.656 0.241 354.308);\n  --color-pink-600: oklch(0.592 0.249 0.584);\n  --color-pink-700: oklch(0.525 0.223 3.958);\n  --color-pink-800: oklch(0.459 0.187 3.815);\n  --color-pink-900: oklch(0.408 0.153 2.432);\n  --color-pink-950: oklch(0.284 0.109 3.907);\n\n  --color-rose-50: oklch(0.969 0.015 12.422);\n  --color-rose-100: oklch(0.941 0.03 12.58);\n  --color-rose-200: oklch(0.892 0.058 10.001);\n  --color-rose-300: oklch(0.81 0.117 11.638);\n  --color-rose-400: oklch(0.712 0.194 13.428);\n  --color-rose-500: oklch(0.645 0.246 16.439);\n  --color-rose-600: oklch(0.586 0.253 17.585);\n  --color-rose-700: oklch(0.514 0.222 16.935);\n  --color-rose-800: oklch(0.455 0.188 13.697);\n  --color-rose-900: oklch(0.41 0.159 10.272);\n  --color-rose-950: oklch(0.271 0.105 12.094);\n\n  --color-slate-50: oklch(0.984 0.003 247.858);\n  --color-slate-100: oklch(0.968 0.007 247.896);\n  --color-slate-200: oklch(0.929 0.013 255.508);\n  --color-slate-300: oklch(0.869 0.022 252.894);\n  --color-slate-400: oklch(0.704 0.04 256.788);\n  --color-slate-500: oklch(0.554 0.046 257.417);\n  --color-slate-600: oklch(0.446 0.043 257.281);\n  --color-slate-700: oklch(0.372 0.044 257.287);\n  --color-slate-800: oklch(0.279 0.041 260.031);\n  --color-slate-900: oklch(0.208 0.042 265.755);\n  --color-slate-950: oklch(0.129 0.042 264.695);\n\n  --color-gray-50: oklch(0.985 0.002 247.839);\n  --color-gray-100: oklch(0.967 0.003 264.542);\n  --color-gray-200: oklch(0.928 0.006 264.531);\n  --color-gray-300: oklch(0.872 0.01 258.338);\n  --color-gray-400: oklch(0.707 0.022 261.325);\n  --color-gray-500: oklch(0.551 0.027 264.364);\n  --color-gray-600: oklch(0.446 0.03 256.802);\n  --color-gray-700: oklch(0.373 0.034 259.733);\n  --color-gray-800: oklch(0.278 0.033 256.848);\n  --color-gray-900: oklch(0.21 0.034 264.665);\n  --color-gray-950: oklch(0.13 0.028 261.692);\n\n  --color-zinc-50: oklch(0.985 0 0);\n  --color-zinc-100: oklch(0.967 0.001 286.375);\n  --color-zinc-200: oklch(0.92 0.004 286.32);\n  --color-zinc-300: oklch(0.871 0.006 286.286);\n  --color-zinc-400: oklch(0.705 0.015 286.067);\n  --color-zinc-500: oklch(0.552 0.016 285.938);\n  --color-zinc-600: oklch(0.442 0.017 285.786);\n  --color-zinc-700: oklch(0.37 0.013 285.805);\n  --color-zinc-800: oklch(0.274 0.006 286.033);\n  --color-zinc-900: oklch(0.21 0.006 285.885);\n  --color-zinc-950: oklch(0.141 0.005 285.823);\n\n  --color-neutral-50: oklch(0.985 0 0);\n  --color-neutral-100: oklch(0.97 0 0);\n  --color-neutral-200: oklch(0.922 0 0);\n  --color-neutral-300: oklch(0.87 0 0);\n  --color-neutral-400: oklch(0.708 0 0);\n  --color-neutral-500: oklch(0.556 0 0);\n  --color-neutral-600: oklch(0.439 0 0);\n  --color-neutral-700: oklch(0.371 0 0);\n  --color-neutral-800: oklch(0.269 0 0);\n  --color-neutral-900: oklch(0.205 0 0);\n  --color-neutral-950: oklch(0.145 0 0);\n\n  --color-stone-50: oklch(0.985 0.001 106.423);\n  --color-stone-100: oklch(0.97 0.001 106.424);\n  --color-stone-200: oklch(0.923 0.003 48.717);\n  --color-stone-300: oklch(0.869 0.005 56.366);\n  --color-stone-400: oklch(0.709 0.01 56.259);\n  --color-stone-500: oklch(0.553 0.013 58.071);\n  --color-stone-600: oklch(0.444 0.011 73.639);\n  --color-stone-700: oklch(0.374 0.01 67.558);\n  --color-stone-800: oklch(0.268 0.007 34.298);\n  --color-stone-900: oklch(0.216 0.006 56.043);\n  --color-stone-950: oklch(0.147 0.004 49.25);\n\n  --color-black: #000;\n  --color-white: #fff;\n\n  --spacing: 0.25rem;\n\n  --breakpoint-sm: 40rem;\n  --breakpoint-md: 48rem;\n  --breakpoint-lg: 64rem;\n  --breakpoint-xl: 80rem;\n  --breakpoint-2xl: 96rem;\n\n  --container-3xs: 16rem;\n  --container-2xs: 18rem;\n  --container-xs: 20rem;\n  --container-sm: 24rem;\n  --container-md: 28rem;\n  --container-lg: 32rem;\n  --container-xl: 36rem;\n  --container-2xl: 42rem;\n  --container-3xl: 48rem;\n  --container-4xl: 56rem;\n  --container-5xl: 64rem;\n  --container-6xl: 72rem;\n  --container-7xl: 80rem;\n\n  --text-xs: 0.75rem;\n  --text-xs--line-height: calc(1 / 0.75);\n  --text-sm: 0.875rem;\n  --text-sm--line-height: calc(1.25 / 0.875);\n  --text-base: 1rem;\n  --text-base--line-height: calc(1.5 / 1);\n  --text-lg: 1.125rem;\n  --text-lg--line-height: calc(1.75 / 1.125);\n  --text-xl: 1.25rem;\n  --text-xl--line-height: calc(1.75 / 1.25);\n  --text-2xl: 1.5rem;\n  --text-2xl--line-height: calc(2 / 1.5);\n  --text-3xl: 1.875rem;\n  --text-3xl--line-height: calc(2.25 / 1.875);\n  --text-4xl: 2.25rem;\n  --text-4xl--line-height: calc(2.5 / 2.25);\n  --text-5xl: 3rem;\n  --text-5xl--line-height: 1;\n  --text-6xl: 3.75rem;\n  --text-6xl--line-height: 1;\n  --text-7xl: 4.5rem;\n  --text-7xl--line-height: 1;\n  --text-8xl: 6rem;\n  --text-8xl--line-height: 1;\n  --text-9xl: 8rem;\n  --text-9xl--line-height: 1;\n\n  --font-weight-thin: 100;\n  --font-weight-extralight: 200;\n  --font-weight-light: 300;\n  --font-weight-normal: 400;\n  --font-weight-medium: 500;\n  --font-weight-semibold: 600;\n  --font-weight-bold: 700;\n  --font-weight-extrabold: 800;\n  --font-weight-black: 900;\n\n  --tracking-tighter: -0.05em;\n  --tracking-tight: -0.025em;\n  --tracking-normal: 0em;\n  --tracking-wide: 0.025em;\n  --tracking-wider: 0.05em;\n  --tracking-widest: 0.1em;\n\n  --leading-tight: 1.25;\n  --leading-snug: 1.375;\n  --leading-normal: 1.5;\n  --leading-relaxed: 1.625;\n  --leading-loose: 2;\n\n  --radius-xs: 0.125rem;\n  --radius-sm: 0.25rem;\n  --radius-md: 0.375rem;\n  --radius-lg: 0.5rem;\n  --radius-xl: 0.75rem;\n  --radius-2xl: 1rem;\n  --radius-3xl: 1.5rem;\n  --radius-4xl: 2rem;\n\n  --shadow-2xs: 0 1px rgb(0 0 0 / 0.05);\n  --shadow-xs: 0 1px 2px 0 rgb(0 0 0 / 0.05);\n  --shadow-sm: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);\n  --shadow-md: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);\n  --shadow-lg: 0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1);\n  --shadow-xl: 0 20px 25px -5px rgb(0 0 0 / 0.1), 0 8px 10px -6px rgb(0 0 0 / 0.1);\n  --shadow-2xl: 0 25px 50px -12px rgb(0 0 0 / 0.25);\n\n  --inset-shadow-2xs: inset 0 1px rgb(0 0 0 / 0.05);\n  --inset-shadow-xs: inset 0 1px 1px rgb(0 0 0 / 0.05);\n  --inset-shadow-sm: inset 0 2px 4px rgb(0 0 0 / 0.05);\n\n  --drop-shadow-xs: 0 1px 1px rgb(0 0 0 / 0.05);\n  --drop-shadow-sm: 0 1px 2px rgb(0 0 0 / 0.15);\n  --drop-shadow-md: 0 3px 3px rgb(0 0 0 / 0.12);\n  --drop-shadow-lg: 0 4px 4px rgb(0 0 0 / 0.15);\n  --drop-shadow-xl: 0 9px 7px rgb(0 0 0 / 0.1);\n  --drop-shadow-2xl: 0 25px 25px rgb(0 0 0 / 0.15);\n\n  --ease-in: cubic-bezier(0.4, 0, 1, 1);\n  --ease-out: cubic-bezier(0, 0, 0.2, 1);\n  --ease-in-out: cubic-bezier(0.4, 0, 0.2, 1);\n\n  --animate-spin: spin 1s linear infinite;\n  --animate-ping: ping 1s cubic-bezier(0, 0, 0.2, 1) infinite;\n  --animate-pulse: pulse 2s cubic-bezier(0.4, 0, 0.6, 1) infinite;\n  --animate-bounce: bounce 1s infinite;\n\n  @keyframes spin {\n    to {\n      transform: rotate(360deg);\n    }\n  }\n\n  @keyframes ping {\n    75%,\n    100% {\n      transform: scale(2);\n      opacity: 0;\n    }\n  }\n\n  @keyframes pulse {\n    50% {\n      opacity: 0.5;\n    }\n  }\n\n  @keyframes bounce {\n    0%,\n    100% {\n      transform: translateY(-25%);\n      animation-timing-function: cubic-bezier(0.8, 0, 1, 1);\n    }\n\n    50% {\n      transform: none;\n      animation-timing-function: cubic-bezier(0, 0, 0.2, 1);\n    }\n  }\n\n  --blur-xs: 4px;\n  --blur-sm: 8px;\n  --blur-md: 12px;\n  --blur-lg: 16px;\n  --blur-xl: 24px;\n  --blur-2xl: 40px;\n  --blur-3xl: 64px;\n\n  --perspective-dramatic: 100px;\n  --perspective-near: 300px;\n  --perspective-normal: 500px;\n  --perspective-midrange: 800px;\n  --perspective-distant: 1200px;\n\n  --aspect-video: 16 / 9;\n\n  --default-transition-duration: 150ms;\n  --default-transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);\n  --default-font-family: var(--font-sans);\n  --default-font-feature-settings: var(--font-sans--font-feature-settings);\n  --default-font-variation-settings: var(--font-sans--font-variation-settings);\n  --default-mono-font-family: var(--font-mono);\n  --default-mono-font-feature-settings: var(--font-mono--font-feature-settings);\n  --default-mono-font-variation-settings: var(--font-mono--font-variation-settings);\n}\n\n/* Deprecated */\n@theme default inline reference {\n  --blur: 8px;\n  --shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);\n  --shadow-inner: inset 0 2px 4px 0 rgb(0 0 0 / 0.05);\n  --drop-shadow: 0 1px 2px rgb(0 0 0 / 0.1), 0 1px 1px rgb(0 0 0 / 0.06);\n  --radius: 0.25rem;\n  --max-width-prose: 65ch;\n}\n",
        utilities: "@tailwind utilities;\n"
    };
    console.warn("The browser build of Tailwind CSS should not be used in production. To use Tailwind CSS in production, use the Tailwind CLI, Vite plugin, or PostCSS plugin: https://tailwindcss.com/docs/installation");
    var It, qt = "text/tailwindcss", Pt = new Set, Ht = "", Yt = document.createElement("style"),
        Zt = Promise.resolve(), Gt = 1, Xt = new class {
            start(e) {
                performance.mark(`${e} (start)`)
            }

            end(e, t) {
                performance.mark(`${e} (end)`), performance.measure(e, {
                    start: `${e} (start)`,
                    end: `${e} (end)`,
                    detail: t
                })
            }

            hit(e, t) {
                performance.mark(e, {detail: t})
            }

            error(e) {
                throw performance.mark("(error)", {detail: {error: `${e}`}}), e
            }
        };

    async function Jt(e, t) {
        try {
            let r = function () {
                if ("tailwindcss" === e) return {base: t, content: Rt.index};
                if ("tailwindcss/preflight" === e || "tailwindcss/preflight.css" === e || "./preflight.css" === e) return {
                    base: t,
                    content: Rt.preflight
                };
                if ("tailwindcss/theme" === e || "tailwindcss/theme.css" === e || "./theme.css" === e) return {
                    base: t,
                    content: Rt.theme
                };
                if ("tailwindcss/utilities" === e || "tailwindcss/utilities.css" === e || "./utilities.css" === e) return {
                    base: t,
                    content: Rt.utilities
                };
                throw new Error(`The browser build does not support @import for "${e}"`)
            }();
            return Xt.hit("Loaded stylesheet", {id: e, base: t, size: r.content.length}), r
        } catch (r) {
            throw Xt.hit("Failed to load stylesheet", {id: e, base: t, error: r.message ?? r}), r
        }
    }

    async function Qt() {
        throw new Error("The browser build does not support plugins or config files.")
    }

    function er(e) {
        Zt = Zt.then((async function () {
            if (!It && "full" !== e) return;
            let t = Gt++;
            Xt.start(`Build #${t} (${e})`), "full" === e && await async function () {
                Xt.start("Create compiler"), Xt.start("Reading Stylesheets");
                let e = document.querySelectorAll(`style[type="${qt}"]`), t = "";
                for (let r of e) rr(r), t += r.textContent + "\n";
                if (t.includes("@import") || (t = `@import "tailwindcss";${t}`), Xt.end("Reading Stylesheets", {
                    size: t.length,
                    changed: Ht !== t
                }), Ht !== t) {
                    Ht = t, Xt.start("Compile CSS");
                    try {
                        It = await Mt(t, {base: "/", loadStylesheet: Jt, loadModule: Qt})
                    } finally {
                        Xt.end("Compile CSS"), Xt.end("Create compiler")
                    }
                    Pt.clear()
                }
            }(), Xt.start("Build"), await async function (e) {
                if (!It) return;
                let t = new Set;
                Xt.start("Collect classes");
                for (let e of document.querySelectorAll("[class]")) for (let r of e.classList) Pt.has(r) || (Pt.add(r), t.add(r));
                Xt.end("Collect classes", {count: t.size}), (0 !== t.size || "incremental" !== e) && (Xt.start("Build utilities"), Yt.textContent = It.build(Array.from(t)), Xt.end("Build utilities"))
            }(e), Xt.end("Build"), Xt.end(`Build #${t} (${e})`)
        })).catch((e => Xt.error(e)))
    }

    var tr = new MutationObserver((() => er("full")));

    function rr(e) {
        tr.observe(e, {attributes: !0, attributeFilter: ["type"], characterData: !0, subtree: !0, childList: !0})
    }

    new MutationObserver((e => {
        let t = 0, r = 0;
        for (let n of e) {
            for (let e of n.addedNodes) e.nodeType === Node.ELEMENT_NODE && "STYLE" === e.tagName && e.getAttribute("type") === qt && (rr(e), t++);
            for (let e of n.addedNodes) 1 === e.nodeType && e !== Yt && r++;
            "attributes" === n.type && r++
        }
        return t > 0 ? er("full") : r > 0 ? er("incremental") : void 0
    })).observe(document.documentElement, {
        attributes: !0,
        attributeFilter: ["class"],
        childList: !0,
        subtree: !0
    }), er("full"), document.head.append(Yt)
})();
//# sourceMappingURL=/sm/e5c39dde32e56be6278cb204398164cc1624bfd96861cfe1885d8d15d22507c1.map