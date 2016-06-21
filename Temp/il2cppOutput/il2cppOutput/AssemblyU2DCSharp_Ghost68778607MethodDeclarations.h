#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// Ghost
struct Ghost_t68778607;
// UnityEngine.Collision2D
struct Collision2D_t452810033;
// UnityEngine.Collider2D
struct Collider2D_t1890038195;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Collision2D452810033.h"
#include "UnityEngine_UnityEngine_Collider2D1890038195.h"

// System.Void Ghost::.ctor()
extern "C"  void Ghost__ctor_m2612894684 (Ghost_t68778607 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Ghost::Start()
extern "C"  void Ghost_Start_m1560032476 (Ghost_t68778607 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Ghost::startGame()
extern "C"  void Ghost_startGame_m1017326350 (Ghost_t68778607 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Ghost::Update()
extern "C"  void Ghost_Update_m1122218673 (Ghost_t68778607 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Ghost::MoveToPlayer()
extern "C"  void Ghost_MoveToPlayer_m3606168533 (Ghost_t68778607 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Ghost::OnCollisionEnter2D(UnityEngine.Collision2D)
extern "C"  void Ghost_OnCollisionEnter2D_m1151617606 (Ghost_t68778607 * __this, Collision2D_t452810033 * ___target0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Ghost::OnTriggerEnter2D(UnityEngine.Collider2D)
extern "C"  void Ghost_OnTriggerEnter2D_m3505614620 (Ghost_t68778607 * __this, Collider2D_t1890038195 * ___target0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
